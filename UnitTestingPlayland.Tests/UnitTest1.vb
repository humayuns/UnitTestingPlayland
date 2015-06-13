Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class UnitTest1

    <TestMethod()> Public Sub TestMethod1()
    End Sub

    <TestMethod()> Public Sub FileExistsOnDesktop()
        Assert.IsTrue(IO.File.Exists("C:\Users\Humayun\Desktop\hello.py"))
    End Sub

End Class