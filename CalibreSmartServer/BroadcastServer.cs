using System.Net.Sockets;
using System.Net;
using System.Text;

namespace CalibreSmartServer;
/// <summary>
/// Boradcast Server 
/// </summary>
public class BroadcastServer
{

    private const string Message_Fomart = "calibre wireless device client (on {0});{1},{2}";
    private const int Server_Broad_Port = 54982;
    private const int Client_Broad_Point = 8134;

    private readonly int calibreServerPort;
    private readonly int calibreHttpServerPort;
    private UdpClient? listener = null;


    public BroadcastServer(int calibrePort,int calibreHttpPort)
    {
        calibreServerPort = calibrePort;
        calibreHttpServerPort= calibreHttpPort;
    }

  

    public  void Start()
    {
        listener = new UdpClient(Server_Broad_Port);
        IPEndPoint groupEP = new IPEndPoint(IPAddress.Any, Server_Broad_Port);

        try
        {
            while (true)
            {
                byte[] bytes = listener.Receive(ref groupEP);
                var greet = Encoding.UTF8.GetString(bytes);
                if (greet=="hello")
                {
                    var mesage = String.Format(Message_Fomart, Environment.MachineName, calibreServerPort, calibreServerPort);
                    var remote = new IPEndPoint(groupEP.Address, Client_Broad_Point);
                    listener.Send(Encoding.UTF8.GetBytes(mesage), remote);
                    Console.WriteLine($"Send to {remote} message: {mesage}");
                }
                
            }
        }
        catch (SocketException e)
        {
            Console.WriteLine(e);
        }
        finally
        {
            listener.Close();
        }
    }

    public  void Stop()
    {
        if (listener!=null)
        {
            listener.Close();
        }
    }
}
