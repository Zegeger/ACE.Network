using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACE.Network.Tools.NetworkViewer.Protocols;

namespace ACE.Network.Tools.NetworkViewer.Parsers
{
    /// <summary>
    /// Parses a PCAP file.
    /// </summary>
    public class NetworkFileParser
    {
        public event EventHandler<PacketReadEventArgs> PacketRead;

        private readonly string path;

        /// <summary>
        /// Creates new instance of NetworkFileParser
        /// </summary>
        /// <param name="path">Path to the pcap file to open.</param>
        public NetworkFileParser(string path)
        {
            this.path = path;
        }

        public PCapFile Parse()
        {
            using (FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                using (BinaryReader binaryReader = new BinaryReader(fileStream))
                {
                    uint magicNumber = binaryReader.ReadUInt32();

                    if (magicNumber == 0xA1B2C3D4 || magicNumber == 0xD4C3B2A1)
                    {
                        var file = new PCapFile(magicNumber);
                        file.PacketRead += File_PacketRead;
                        file.Parse(binaryReader);
                        return file;
                    }
                }
            }
            return null;
        }

        private void File_PacketRead(object sender, PacketReadEventArgs e)
        {
            PacketRead?.Invoke(this, e);
        }
    }
}
