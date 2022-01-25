using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace YuanshenAnti
{
    internal class Program
    {
        async void Main(string[] args)
        {
            try
            {
                var path = "/Users/owen/Library/Containers/com.miHoYo.Yuanshen/Data/Library/MihoyoDownload/Persistent";
                var path_remote = Path.Combine(path, "silence_data_versions_remote");
                var path_presist = Path.Combine(path, "silence_data_versions_persist");
                var silence_rev = Path.Combine(path, "silence_revision");
                var res_rev = Path.Combine(path, "res_revision");
                var data_rev = Path.Combine(path, "data_revision");
                var audio_rev = Path.Combine(path, "audio_revision");

                if (File.Exists(silence_rev))
                {
                    File.Delete(silence_rev);
                }

                if (File.Exists(audio_rev))
                {
                    File.Delete(audio_rev);
                }

                if (File.Exists(res_rev))
                {
                    File.Delete(res_rev);
                }

                if (File.Exists(data_rev))
                {
                    File.Delete(data_rev);
                }


                while (true)
                {
                    var ps = Process.GetProcessesByName("Yuanshen");
                    if (ps.Any())
                    {
                        break;
                    }
                    Console.WriteLine("正在等待原神启动");
                    await Task.Delay(1000);
                }

                var i = 0;
                var f = 0;

                while (true)
                {
                    if (File.Exists(path_remote))
                    {
                        try
                        {
                            File.SetAttributes(path_remote, FileAttributes.Normal);
                            await File.WriteAllTextAsync(path_remote, "");
                            if (i > 90 && await File.ReadAllTextAsync(path_remote) == "")
                            {
                                break;
                            }
                            i++;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("设置remote出错", ex);
                        }
                    }

                    if (File.Exists(path_presist))
                    {
                        try
                        {
                            File.SetAttributes(path_presist, FileAttributes.Normal);
                            await File.WriteAllTextAsync(path_presist, "");
                            if (f > 90 && await File.ReadAllTextAsync(path_presist) == "")
                            {
                                break;
                            }
                            f++;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("设置presist出错", ex);
                        }
                    }

                    if (i > 120 && f > 120)
                    {
                        break;
                    }

                    await Task.Delay(1000);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Console.WriteLine("按任意键退出");
            Console.ReadKey();
        }
    }
}
