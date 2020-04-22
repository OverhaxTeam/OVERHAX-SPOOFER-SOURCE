param($installPath, $toolsPath, $package, $project)

$file1 = $project.ProjectItems.Item("Database.dacpac")
$file2 = $project.ProjectItems.Item("msdb.dacpac")
$file3 = $project.ProjectItems.Item("master.dacpac")

# set 'Copy To Output Directory' to 'Copy if newer'
$copyToOutput1 = $file1.Properties.Item("CopyToOutputDirectory")
$copyToOutput1.Value = 1

$copyToOutput2 = $file2.Properties.Item("CopyToOutputDirectory")
$copyToOutput2.Value = 1

$copyToOutput3 = $file3.Properties.Item("CopyToOutputDirectory")
$copyToOutput3.Value = 1