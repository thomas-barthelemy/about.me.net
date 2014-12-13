namespace AboutNet

open System
open Newtonsoft.Json

[<AbstractClassAttribute>]
type ResponseBase() = 
    member val Status : int = 0 with get, set
    [<JsonPropertyAttribute("error_message")>]
    member val ErrorMessage : string = null with get, set
    [<JsonPropertyAttribute("error_code")>]
    member val ErrorCode : int = 0 with get, set

module User =
    type View() =
        inherit ResponseBase()
        member val Profile : string = null with get, set