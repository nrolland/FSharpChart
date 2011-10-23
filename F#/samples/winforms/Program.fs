namespace MSDN.FSharp.Charting.Tester

open System
open System.Drawing
open System.Windows.Forms

module Main =

    [<STAThread>]
    do
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(false)
        Application.Run(new CombineLineForm() :> Form) // Can also either CombineLineForm or BoxplotForm
