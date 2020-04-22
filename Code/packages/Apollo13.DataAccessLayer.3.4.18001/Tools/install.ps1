param($installPath, $toolsPath, $package, $project)
#$project.ProjectItems.Item("Sql").ProjectItems.Item("2012").ProjectItems.Item("Microsoft.Data.Tools.Schema.Sql.dll").Properties.Item("CopyToOutputDirectory").Value = [int]1;
#$project.ProjectItems.Item("Sql").ProjectItems.Item("2012").ProjectItems.Item("Microsoft.Data.Tools.Utilities.dll").Properties.Item("CopyToOutputDirectory").Value = [int]1;
#$project.ProjectItems.Item("Sql").ProjectItems.Item("2012").ProjectItems.Item("Microsoft.SqlServer.Dac.dll").Properties.Item("CopyToOutputDirectory").Value = [int]1;

#$project.ProjectItems.Item("Sql").ProjectItems.Item("2014").ProjectItems.Item("Microsoft.Data.Tools.Schema.Sql.dll").Properties.Item("CopyToOutputDirectory").Value = [int]1;
#$project.ProjectItems.Item("Sql").ProjectItems.Item("2014").ProjectItems.Item("Microsoft.Data.Tools.Utilities.dll").Properties.Item("CopyToOutputDirectory").Value = [int]1;
#$project.ProjectItems.Item("Sql").ProjectItems.Item("2014").ProjectItems.Item("Microsoft.SqlServer.Dac.dll").Properties.Item("CopyToOutputDirectory").Value = [int]1;

#$project.ProjectItems.Item("Sql").ProjectItems.Item("2016").ProjectItems.Item("Microsoft.Data.Tools.Schema.Sql.dll").Properties.Item("CopyToOutputDirectory").Value = [int]1;
#$project.ProjectItems.Item("Sql").ProjectItems.Item("2016").ProjectItems.Item("Microsoft.Data.Tools.Utilities.dll").Properties.Item("CopyToOutputDirectory").Value = [int]1;
#$project.ProjectItems.Item("Sql").ProjectItems.Item("2016").ProjectItems.Item("Microsoft.SqlServer.Dac.dll").Properties.Item("CopyToOutputDirectory").Value = [int]1;


# set 'Copy To Output Directory' to 'Always'
#    0 = Never
#    1 = Always
#    2 = PreserveNewestFile

# set 'Build Action' to 'Content'
#    0 = None
#    1 = Compile
#    2 = Content
#    3 = EmbeddedResource

#SQL 2012
$configItem = $project.ProjectItems.Item("Sql").ProjectItems.Item("2012").ProjectItems.Item("Microsoft.Data.Tools.Schema.Sql.dll");
$configItem.Properties.Item("CopyToOutputDirectory").Value = [int]1;
$configItem.Properties.Item("BuildAction").Value = [int]0;

$configItem = $project.ProjectItems.Item("Sql").ProjectItems.Item("2012").ProjectItems.Item("Microsoft.Data.Tools.Utilities.dll");
$configItem.Properties.Item("CopyToOutputDirectory").Value = [int]1;
$configItem.Properties.Item("BuildAction").Value = [int]0;

$configItem = $project.ProjectItems.Item("Sql").ProjectItems.Item("2012").ProjectItems.Item("Microsoft.SqlServer.Dac.dll");
$configItem.Properties.Item("CopyToOutputDirectory").Value = [int]1;
$configItem.Properties.Item("BuildAction").Value = [int]0;

#SQL 2014
$configItem = $project.ProjectItems.Item("Sql").ProjectItems.Item("2014").ProjectItems.Item("Microsoft.Data.Tools.Schema.Sql.dll");
$configItem.Properties.Item("CopyToOutputDirectory").Value = [int]1;
$configItem.Properties.Item("BuildAction").Value = [int]0;

$configItem = $project.ProjectItems.Item("Sql").ProjectItems.Item("2014").ProjectItems.Item("Microsoft.Data.Tools.Utilities.dll");
$configItem.Properties.Item("CopyToOutputDirectory").Value = [int]1;
$configItem.Properties.Item("BuildAction").Value = [int]0;

$configItem = $project.ProjectItems.Item("Sql").ProjectItems.Item("2014").ProjectItems.Item("Microsoft.SqlServer.Dac.dll");
$configItem.Properties.Item("CopyToOutputDirectory").Value = [int]1;
$configItem.Properties.Item("BuildAction").Value = [int]0;

#SQL 2016
$configItem = $project.ProjectItems.Item("Sql").ProjectItems.Item("2016").ProjectItems.Item("Microsoft.Data.Tools.Schema.Sql.dll");
$configItem.Properties.Item("CopyToOutputDirectory").Value = [int]1;
$configItem.Properties.Item("BuildAction").Value = [int]0;

$configItem = $project.ProjectItems.Item("Sql").ProjectItems.Item("2016").ProjectItems.Item("Microsoft.Data.Tools.Utilities.dll");
$configItem.Properties.Item("CopyToOutputDirectory").Value = [int]1;
$configItem.Properties.Item("BuildAction").Value = [int]0;

$configItem = $project.ProjectItems.Item("Sql").ProjectItems.Item("2016").ProjectItems.Item("Microsoft.SqlServer.Dac.dll");
$configItem.Properties.Item("CopyToOutputDirectory").Value = [int]1;
$configItem.Properties.Item("BuildAction").Value = [int]0;