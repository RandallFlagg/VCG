Imports VisualCodeGrepper.NETCore.Lib

Module MyConsole

    Sub Main()

        ' Parse and process any command line args
        Dim args As New List(Of String)
        args.AddRange(Environment.GetCommandLineArgs().ToArray())
        args.Add("-c") 'Required for the setting <asAppSettings.IsConsole> to be true 

        Dim retCode = ParseArgs(args)

        ' Early exit
        If retCode = EXIT_CODE Then
            'ShowHelp()
            Return
        End If

        Dim program As New Program
        SelectLanguage(program, asAppSettings.TestType)
        LoadFiles(program, rtResultsTracker.TargetDirectory)
        ScanFiles(program, True, True)

    End Sub

End Module