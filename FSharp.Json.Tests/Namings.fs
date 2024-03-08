namespace FSharp.Json

module LowerCamelCase =
    open System
    open NUnit.Framework
    open NUnit.Framework.Legacy

    [<Test>]
    let ``Single word`` () =
        ClassicAssert.AreEqual("property", Json.lowerCamelCase ("Property"))

    [<Test>]
    let ``No changes needed`` () =
        ClassicAssert.AreEqual("property", Json.lowerCamelCase ("property"))

    [<Test>]
    let ``Two words`` () =
        ClassicAssert.AreEqual("twoWords", Json.lowerCamelCase ("TwoWords"))

    [<Test>]
    let ``Abbreviations`` () =
        ClassicAssert.AreEqual("somethingTbd", Json.lowerCamelCase ("SomethingTBD"))

module SnakeCase =
    open System
    open NUnit.Framework
    open NUnit.Framework.Legacy

    [<Test>]
    let ``Single word`` () =
        ClassicAssert.AreEqual("property", Json.snakeCase ("Property"))

    [<Test>]
    let ``No changes needed`` () =
        ClassicAssert.AreEqual("property", Json.snakeCase ("property"))

    [<Test>]
    let ``Two words`` () =
        ClassicAssert.AreEqual("two_words", Json.snakeCase ("TwoWords"))

    [<Test>]
    let ``Abbreviations`` () =
        ClassicAssert.AreEqual("something_tbd", Json.snakeCase ("SomethingTBD"))
