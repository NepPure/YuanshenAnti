using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace YuanshenAnti
{
    internal class Program
    {
        public static void Main()
        {
            MainAsync().GetAwaiter().GetResult();
        }

        private static async Task MainAsync()
        {
            Console.WriteLine(@"                       注意！！！
                本脚本涉及修改游戏文件
                不保证完全没有封号风险
        使用说明：
                每次重启游戏后恢复正常
                本脚本将 角色建模 及 飞行时的模糊 恢复到2.3
                每次使用本脚本启动游戏，游戏内都将重新校验游戏资源                
            
                本脚本完全开源
                如有顾虑请不要使用

        使用本脚本即视为同意以下条款：
            1、本脚本完全用作技术交流、学习，用作其他用途产生的一切损失由使用者承担
            2、若使用本脚本对任何集体、个人、团体、集团、公司的合法利益造成侵害，一切责任由使用者承担
            3、不合理合法合规使用本脚本，造成的一切损失均由使用者承担，与作者无关
            4、使用本脚本产生的一切损失由使用者承担
            5、如不同意以上内容，请立即退出并完全删除此脚本

本项目源码来自以下大佬的python脚本
    本脚本已经集成了 op2.4.exe 反虚化及解锁帧率 作者：果果  群：720386284
    作者：南辰燏炚 QQ:3546599908
    交流群：777974176 (北幽冒险家公会) 
");

            Console.WriteLine("继续使用即视为完全阅读且同意以上内容\n按任意键继续或者关闭脚本：");
            Console.ReadKey();

            try
            {
                var path = "/Users/owen/Library/Containers/com.miHoYo.Yuanshen/Data/Library/MihoyoDownload/Persistent";
                Console.WriteLine("请输入Persistent文件夹路径，以Persistent结束，例如“/Users/owen/Library/Containers/com.miHoYo.Yuanshen/Data/Library/MihoyoDownload/Persistent”Windows版本在游戏安装目录下：");
                var customPath = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(customPath))
                {
                    path = customPath;
                }

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
                    //mac
                    var ps = Process.GetProcessesByName("Yuanshen");
                    if (ps.Any())
                    {
                        break;
                    }
                    //windows
                    ps = Process.GetProcessesByName("YuanShen.exe");
                    if (ps.Any())
                    {
                        break;
                    }
                    Console.WriteLine("正在等待原神启动");
                    await Task.Delay(1000);
                }

                Console.WriteLine("原神已启动");

                var i = 0;
                var f = 0;
                Console.WriteLine("(╯‵□′)╯︵┻━┻...中，进入游戏后即可关闭脚本");
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
