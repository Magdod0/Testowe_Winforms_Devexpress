using DevExpress.XtraPrinting.Native.WebClientUIControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Testowe_WinF_Dev.DataModels.GithubAPI
{
    public class GitHubRepository
    {
        public string name { get; set; }
        public DateTime created_at { get; set; }
        public int stargazers_count { get; set; }
        public override string ToString()
        {
            return $"Project name: {name}, Stars: {stargazers_count}, Date of creation: {created_at}";
        }
    }
}
