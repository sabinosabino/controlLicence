Imports System
Public Class GetId

    Public Function GetId() As String
        Dim mInfo As New System.Management.ManagementClass("Win32_LogicalDisk")
        Dim disks As System.Management.ManagementObjectCollection = mInfo.GetInstances()
        Dim disk As System.Management.ManagementObject

        For Each disk In disks

            If CStr(disk("Name")) = "C:" Then

                Return disk("VolumeSerialNumber").ToString()

            End If

        Next disk
        Return ""
    End Function

End Class
