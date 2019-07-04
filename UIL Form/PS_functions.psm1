#Make folder
Function make-folder {New-item C:\temp -ItemType Directory}
#Move File
Function move-file {Get-ChildItem -Path ".\*.mp3" -Recurse | Move-Item -Destination "C:\temp"}
#Get USB Letter
Function get-usb {gwmi win32_diskdrive | ?{$_.interfacetype -eq "USB"} | %{gwmi -Query "ASSOCIATORS OF {Win32_DiskDrive.DeviceID=`"$($_.DeviceID.replace('\','\\'))`"} WHERE AssocClass = Win32_DiskDriveToDiskPartition"} | %{gwmi -Query "ASSOCIATORS OF {Win32_DiskPartition.DeviceID=`"$($_.DeviceID)`"} WHERE AssocClass = Win32_LogicalDiskToPartition"} | %{$_.deviceid} }
#Rename files
Function find-rename {Get-ChildItem -Path ".\*.mp3" -Recurse | %{Rename-Item $_ -NewName ('MP3_{0:D2}.mp3' -f $i++)}}
#Reset I
Function reset-i {$i=0}

Actual functions:
set location D:
