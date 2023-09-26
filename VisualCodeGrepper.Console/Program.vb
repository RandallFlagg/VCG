Imports System.IO
Imports System.Net.Mime.MediaTypeNames
Imports VisualCodeGrepper.NETCore.Lib

Module MyConsole

    Sub Main()

        ' Parse and process any command line args
        Dim args As New List(Of String)
        args.AddRange(Environment.GetCommandLineArgs().ToArray())
        args.Add("-c") 'For this settings to be true: asAppSettings.IsConsole

        Dim retCode = ParseArgs(args)

        ' Early exit
        If retCode = EXIT_CODE Then
            'Me.Close()
            'Return
        End If

    End Sub

End Module