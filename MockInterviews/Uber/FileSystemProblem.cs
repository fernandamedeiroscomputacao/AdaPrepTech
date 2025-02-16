using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaPrepTech.MockInterviews.Uber
{
    /*

Implement file system APIs based on the following classes.
The functions will mimic their respective Linux commands.



Phase 1: Implement mkdir(dirname : string)  
(make directory) create a new directory from the current working directory
Input: name of directory
Output: print a message if the directory already exists


Phase 2: Implement pwd()
(print working directory) display the path to the current working directory
Input: none
Output: print the current path to std out. e.g. ⇒ “/example/path/”
Output 2: If root ⇒ “/”

Phase 3: Implement cd(path: string)
(change directory) switch the current working directory. If the path starts with a “/” the absolute path (starting from root) should be searched, otherwise start from the current working directory.
The path may contain a directory wildcard. The directory wildcard can match any children directories, the current directory ‘.’ or the parent directory ‘..’


Input: path string
Output: 
If path does not exist, print an error message
If multiple paths exist, display all of them.

*/


    // Clarifying examples
    // Given the following existing directory structure: dirA/dirB/dirTarget:
    // The command cd(“dirA/*/dirTarget” ) would change the working path to “dirA/dirB/dirTarget”

    // Given the following existing directory structure:
    // dirA/dirB/dirTarget
    // dirA/dirC/dirTarget
    // The command cd(“dirA/*/dirTarget”) would NOT change the working path, and would print out the multiple paths that match.





    // FileSystem fs = new FileSystem();
    // fs.pwd();                  /* --> / (root) */
    // fs.mkdir("Users");         /* make directory Users under / (root) */
    // fs.cd("Users");            /* --> /Users */
    // 
    // 
    // fs.mkdir("User1");         /* make directory User1 at /Users */
    // fs.mkdir("User2");         /* make directory User2 at /Users */
    // fs.cd("User1");            /* --> /Users/Users1 */
    // fs.mkdir("Photos");        /* --> make directory Photos under user 1 */
    // fs.cd("../User2");
    // fs.mkdir("Photos");
    // 
    // 
    // fs.cd("/");                /* --> / (root) */  
    // fs.cd("/*/*/Photos");      /* --> multiple paths found [list] */

    // cd: multiple paths found: /*/*/Photos
    //    /Users/User2/Photos
    //    /Users/User1/Photos


    // fs.pwd();                  /* --> / */
    // fs.cd("/Users/User1/Photos");
    // fs.cd("Users/User1/Photos");
    // fs.pwd();                  /* --> /Users/User1/Photos */
    // fs.cd("fakepath");         /* --> no such directory */



    public class Solution
    {
        public static void Main()
        {
            var system = new FileSystem();


            system.mkdir("Hello");
            system.mkdir("Hello");
            foreach (var dic in system.Current.Children)
            {
                Console.WriteLine(dic.Key);
            }

            system.pwd();

        }

        public class FileSystem
        {
            public Directory Root { get; }
            public Directory Current { get; private set; }

            public FileSystem()
            {
                Root = new();
                Current = Root;
            }

            public void mkdir(string name)
            {
                if (!Current.Children.ContainsKey(name))
                {
                    Current.Children.Add(name, new Directory(name, Current));
                }
                else
                {
                    Console.WriteLine("Already Exists");
                }
            }

            public void pwd()
            {
                string path = "";

                if (Current == Root)
                {
                    path = "/";
                }
                else
                {
                    var atual = Current;

                    while (atual != Root)
                    {
                        path = "/" + atual.Name + path;
                        atual = atual.Parent;
                    }
                }
                Console.WriteLine(path);
            }

            /*    public void cd(string path)
                {
                    if (path = "/")
                    {
                        Current = Root;
                    }
                    else
                    {
                        var arrPath = path.Split("/");
                    }

                    string res = "";

                    if (path[0] == "/")
                    {
                        var atual = Root;

                        while (atual.Name != arrPath[arrPath.Lenght - 1])
                        {
                            path = "/" + atual.Name + path;
                            atual = atual.Children;
                        }
                    }


                }*/

            public class Directory
            {

                public Directory()
                {
                    Name = "";
                    Children = new();
                }

                public Directory(String name, Directory parent)
                {
                    Name = name;
                    Parent = parent;
                    Children = new();
                }

                public String Name { get; }
                public Directory Parent { get; }
                public Dictionary<String, Directory> Children { get; }
            }
        }




    }

}
