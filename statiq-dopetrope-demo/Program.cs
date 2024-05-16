Console.WriteLine($"GH-Token: {Config.FromSetting<string>("GITHUB_TOKEN")}");
return await Bootstrapper
  .Factory
  .CreateWeb(args)
  .DeployToGitHubPagesBranch(
        "suchja",
        "statiq-dopetrope-demo",
        Config.FromSetting<string>("GITHUB_TOKEN"),
        "main")
  .RunAsync();
  