using System.Collections.Generic;
using ADotNet.Clients;
using ADotNet.Models.Pipelines.GithubPipelines.DotNets;
using ADotNet.Models.Pipelines.GithubPipelines.DotNets.Tasks;
using ADotNet.Models.Pipelines.GithubPipelines.DotNets.Tasks.SetupDotNetTaskV1s;

var githubPiplene = new GithubPipeline
{
    Name = "Distribution",

    OnEvents = new Events
    {
        Push = new PushEvent
        {
            Branches = new string[] { "Mastre" }
        },

        PullRequest = new PullRequestEvent
        {
            Branches = new string[] { "Master" }
        }
    },

    Jobs = new Jobs
    {
        Build = new BuildJob
        {
            RunsOn = BuildMachines.WindowsLatest,

            Steps = new List<GithubTask>
                 {
                     new CheckoutTaskV2
                     {
                          Name = "Checking out"
                     },

                     new SetupDotNetTaskV1
                     {
                           Name = "Instaling .Net",

                            TargetDotNetVersion = new TargetDotNetVersion
                            {
                                 DotNetVersion = "7.0.200"
                            }
                     },

                     new RestoreTask
                     {
                          Name = "Restoring Task"
                     },

                     new DotNetBuildTask
                     {
                          Name = "Building Task"
                     },

                     new TestTask
                     {
                          Name = "Testing Task"
                     }
                 }
        }
    }


};

var clint = new ADotNetClient();
clint.SerializeAndWriteToFile(
    githubPiplene,
    path: ("../../../../.github/workflows/build.yml"));