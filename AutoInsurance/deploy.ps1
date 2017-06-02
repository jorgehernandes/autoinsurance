param
(		
    [string]$Origem,
    [string]$Destino,
    [string]$Ambiente,
    [string]$Projeto
)

Write-Output "PARANDO SERVICO IIS"
Invoke-Command -ScriptBlock { iisreset /stop } | % { if($_.ToString() -ne "") { Write-Output $_ } }
Write-Output "Ok"
Write-Output ""


Write-Output "COPIANDO ARTEFATOS"
try
{
    $itens = Get-ChildItem $Origem | Where-Object {$_.Name -NotContains "deploy.ps1"}

    $Destino = $Destino + "\" + $Ambiente + "\" + $Projeto

    if (-Not (Test-Path $Destino)) 
    {
        New-Item -ItemType directory -Path $Destino
    }

    foreach($item in $itens)
    {
        Write-Output ("Copiando " + $item.FullName + " para " + $Destino)
        Copy-Item $item.FullName $Destino -recurse -Force	
    }
}
catch
{
    throw
}	
Write-Output "Ok"
Write-Output ""

Write-Output "INICIANDO SERVICO IIS"
Invoke-Command -ScriptBlock { iisreset /start } | % { if($_.ToString() -ne "") { Write-Output $_ } }
Write-Output "Ok"
Write-Output ""

#deploy.ps1 -Origem "C:\Program Files (x86)\Jenkins\workspace\commit\AutoInsurance\bin" -Destino "C:\N3\WEB_IIS" -Ambiente "QA" -Projeto "AutoInsurance"