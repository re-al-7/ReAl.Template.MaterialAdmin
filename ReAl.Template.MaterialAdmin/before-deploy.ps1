# Function to determine if theres a file lock on the given file
Param(
  [Parameter(Mandatory = $true)]
  [string]$serviceName,
  [Parameter(Mandatory = $true)]
  [string]$appFolder
)

function Is-Any-Locked($filePaths) {
	Foreach ($filepath in $filePaths) {
		$fileFullName = $filepath.FullName	
		If (-Not (Test-Path $fileFullName)){
			Write-Host "$filepath does not exist";	
		}
	
		$fileInfo = New-Object System.IO.FileInfo $fileFullName
		try {
			$filestream = $fileInfo.Open([System.IO.FileMode]::Open, [System.IO.FileAccess]::ReadWrite, [System.IO.FileShare]::None);
			$filestream.Close();
			$filestream.Dispose();
		}
		catch {
			return $true
		}
	}
	
	return $false
}

$serviceStatus = (Get-Service $serviceName).Status
$testfiles = Get-ChildItem -Path "$appFolder\*" -Include *.dll, *.exe | Select FullName

# Stop the service
If (-Not ($serviceStatus -Eq 'Stopped')) {
	Write-Host "Stopping service $service..."
	Stop-Service $serviceName
}

# Keep waiting until .dlls are no longer locked by threads
Write-Host 'Awaiting file locks to be released...'
While ($true) {
	If (Is-Any-Locked $testfiles) {
		Start-Sleep 1
	} 
	Else {
		Break;
	}
}

# Write success
Write-Host "All file locks have been released!"