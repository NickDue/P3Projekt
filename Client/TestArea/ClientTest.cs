using Xunit;
using System.Net.Sockets;
using System.Net;
using System.Text;
using Client;

namespace TestArea
{
    public class ClientTest
    {
        private const int PORT_NO = 7777;
        private const string IP = "127.0.0.1";
        [Fact]
        public void ConnectionTestClient()
        {
            TcpClient client = new TcpClient(IP, PORT_NO);
        }
        [Fact]
        public void ConnectionTestServer()
        {
            TcpListener server = new TcpListener(IPAddress.Parse(IP), PORT_NO);
        }
        [Fact]

        public void DataConverter()
        {
            string input = "New York ! 21221 ! 4.0 ! 23 ! 133";
            TestValidationInput test = new TestValidationInput();
            byte[] converted = test.ConvertDataStringToByte(input);
            string expected = test.ConvertDataByteToString(converted);


            Assert.Equal(expected, input);
        }
    }
   
}
