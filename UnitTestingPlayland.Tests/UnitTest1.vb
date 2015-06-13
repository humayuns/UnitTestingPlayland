Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class UnitTest1

    <TestMethod()> Public Sub TestMethod1()
    End Sub

    <TestMethod()> Public Sub FileExistsOnDesktop()
        Assert.IsTrue(IO.File.Exists("C:\Users\Humayun\Desktop\hello.py"))
    End Sub

    <TestMethod()> Public Sub AddInt2Plus2Is4()

        Dim c As New UnitTestingPlayland.Code.Class1

        Assert.IsTrue(c.AddInt(2, 2) = 4)
    End Sub

End Class