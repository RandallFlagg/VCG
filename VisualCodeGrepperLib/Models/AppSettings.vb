﻿' VisualCodeGrepper - Code security scanner
' Copyright (C) 2012-2014 Nick Dunn and John Murray
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports System.IO
Imports System.Reflection

Public Class AppSettings

    '==========================================
    '== Identifiers for RTB results grouping ==
    '------------------------------------------
    Public Const INDIVIDUAL = 0
    Public Const ISSUEGROUP = 1
    Public Const FILEGROUP = 2
    '==========================================

    'TODO: Change to Friend or Private
    'TODO: Change to Const
    '====================================================================
    '== Config files to hold dangerous function names and descriptions ==
    '--------------------------------------------------------------------
    Public BadCommentFile As String = "badcomments.conf"
    Public CConfFile As String = "cppfunctions.conf"
    Public JavaConfFile As String = "javafunctions.conf"
    Public PLSQLConfFile As String = "plsqlfunctions.conf"
    Public Shared CSharpConfFile As String = "csfunctions.conf" 'TODO: DEL
    Public VBConfFile As String = "vbfunctions.conf"
    Public PHPConfFile As String = "phpfunctions.conf"
    Public COBOLConfFile As String = "cobolfunctions.conf"
    Public RConfFile As String = "rfunctions.conf"
    '====================================================================


    '==============================================
    '== Standard file suffixes for each language ==
    '----------------------------------------------
    Public IsAllFileTypes As Boolean = False

    Public CSuffixes As String = ".cpp|.hpp|.c|.h"
    Public JavaSuffixes As String = ".java|.jsp|.jspf|web.xml|config.xml"
    Public PLSQLSuffixes As String = ".pls|.pkb|.pks"
    Public CSharpSuffixes As String = ".cs|.aspx|web.config"
    Public VBSuffixes As String = ".vb|.asp|.aspx|web.config"
    Public PHPSuffixes As String = ".php|.php3|php.ini"
    Public COBOLSuffixes As String = ".cob|.cbl|.clt|.cl2|.cics"
    Public RSuffixes As String = ".r"

    Public FileSuffixes() As String
    Public NumSuffixes As Integer = 0
    '==============================================

    '=================================
    '== Settings for COBOL programs ==
    '---------------------------------
    Public COBOLStartColumn As Integer = 7
    Public IsZOS As Boolean = True
    '=================================

    '===================================================================
    '== Initialise arrays at start - these hold bad stuff to look for ==
    '-------------------------------------------------------------------
    ' Comments indicating untrusted/unfinished code
    'Public BadComments As Array = {"fixme", "fix me", "todo" & Environment.NewLine, "to do" & Environment.NewLine, "todo ", "todo:", "to do ", "wtf", "???", "hardcoded", "hard coded", "removeme", "dangerous method", "fixthis", "fix this", "crap", "shit", "bodge", "kludge", "kluge", "dunno", "assume"}
    Public BadComments As New ArrayList
    'Public CommentArraySize As Integer = 21

    ' File and array of bad functions
    Public BadFunctions As New ArrayList
    Public BadFuncFile As String = CConfFile
    '===================================================================


    '===================================================
    '== Start with C/C++ as the default language type ==
    '---------------------------------------------------
    Public TestType As Integer = Language.C
    Public StartType As Integer = Language.C
    Public SingleLineComment As String = "//"
    Public AltSingleLineComment As String = ""      ' Some languages (VB, PHP...) have more than one single line comment indicator, e.g. VB allows REM or '
    Public BlockStartComment As String = "/*"
    Public BlockEndComment As String = "*/"
    '===================================================


    '=========================
    '== Output file details ==
    '-------------------------
    Public IsOutputFile As Boolean = False
    Public OutputFile As String = ""
    Public IsXmlOutputFile As Boolean = False
    Public XmlOutputFile As String = ""
    Public IsCsvOutputFile As Boolean = False
    Public CsvOutputFile As String = ""
    '=========================

    '=========================
    '== Input file details ==
    '-------------------------
    Public IsXmlInputFile As Boolean = False
    Public XmlInputFile As String = ""
    Public IsCsvInputFile As Boolean = False
    Public CsvInputFile As String = ""
    Public TargetDirectory As String = ""
    '=========================

    '==================================
    '== settings for optional checks ==
    '----------------------------------
    Public IsFinalizeCheck As Boolean = True    ' Check for finalization of Java classes as per OWASP recommendations
    Public IsInnerClassCheck As Boolean = True  ' Check for nesting of Java classes as per OWASP recommendations
    Public IsConfigOnly As Boolean = False      ' Do we want to limit code checks to file content only, or do a full test?
    Public IsAndroid As Boolean = False          ' Include any Java checks for Android issues
    Public IsHelp As Boolean = False
    '==================================

    '=========================================================
    '== Include beta functionality if requested by the user ==
    '---------------------------------------------------------
    Public IncludeBeta As Boolean = False
    Public IncludeSigned As Boolean = False
    Public IncludeCobol As Boolean = True
    Public IncludeR As Boolean = False
    '=========================================================

    ' == Runtime Settings
    Friend Shared ReadOnly ApplicationDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ' Get the path to the executable file.
    Friend Shared ReadOnly ConfigPath = Path.Combine(ApplicationDirectory, "config")
    Friend Shared ReadOnly BadCommentFilePath = Path.Combine(ConfigPath, asAppSettings.BadCommentFile)

    Public AbortCurrentOperation As Boolean = False

    '== The current colour for items which have been checked in the results list ==
    Public ListItemColour As Color = Color.LawnGreen

    '== Show visual breakdown when finished? (set by user options) ==
    Public VisualBreakdownEnabled As Boolean = False
    Public DisplayBreakdownOption As Boolean = True

    '== Report output level - show this level and above ==
    Public OutputLevel As Integer = CodeIssue.POSSIBLY_SAFE

    '== Settings for Rich Text results  display ==
    Public RTBGrouping As Integer = INDIVIDUAL

    '== Settings for console ouput ==
    Public IsConsole As Boolean = False
    Public IsVerbose As Boolean = False

    '== Settings for Temporary Grep
    Public TempGrepText As String = ""

End Class