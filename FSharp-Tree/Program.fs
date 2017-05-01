// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
open System


type Node = { 
            Left:Option<Node>;
            Right:Option<Node>;
            Int:int 
        }

let root:Option<Node> = Some { 

    Left = Some {
                        
            Left = Some {
                Left = Option.None;
                Right = Option.None;
                Int = 4
            };
                                            
            Right = Some {
                Left = Some {
                        Left = Option.None;
                        Right = Option.None;
                        Int = 10
                    }

                Right =  Some {
                        Left = Option.None;
                        Right = Option.None;
                        Int = 14
                    }

                Int = 12
            };
                                                
            Int = 8
        };  
    Right = Some {
            Left = Option.None;
            Right = Option.None;
            Int = 22
        };

    Int = 20 

};
 

let rec findNode (root:Option<Node>) n:int =
    match root with
    | None -> 
        printfn "not found %i" n
        n
    | Some root ->
            match root.Int  with
            | x  when x=n ->
                    printfn "found %i" n
                    n
            | x when x<n -> 
                    printfn  "search value %i greater than %i" n x
                    findNode root.Right n
            | x when x>n -> 
                    printfn  "search value %i less than %i" n x
                    findNode root.Left n


[<EntryPoint>]
let main argv = 
    printfn "%A" argv

    findNode root 14

    Console.ReadKey() |> ignore
   
    0 // return an integer exit code
