return await Bootstrapper
  .Factory
  .CreateWeb(args)
  .DeployToGitHubPagesBranch(
        "suchja",
        "statiq-dopetrope-demo",
        Config.FromSetting<string>("GITHUB_TOKEN"),
        "gh-pages")
  .RunAsync();
  