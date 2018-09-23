<#
for ($i = 0 ; $i -lt 20; $i++)
{
 Invoke-WebRequest -uri http://localhost:44606/
}
#>

for ($i = 0 ; $i -lt 20; $i++)
{
 Invoke-WebRequest -uri http://dotnetcore-pmc.azurewebsites.net/
}