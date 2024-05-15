return await Bootstrapper
  .Factory
  .CreateWeb(args)
  .DeployToGitHubPagesBranch(
        "suchja",
        "suchja.github.io",
        Config.FromSetting<string>("GITHUB_TOKEN"),
        "main")
  .RunAsync();
  