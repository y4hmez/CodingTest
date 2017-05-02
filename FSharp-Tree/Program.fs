// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
open System
open Node

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
 
    
    
[<EntryPoint>]
let main argv = 
    printfn "%A" argv

    let searchNumber = 14
    //let found = findNode root 14
    //let NumberIsInTree = findNode root
    //let foundNode = getNode root searchNumber

    let NumberIsInTree = getNode root                                     

    //printfn "Found Node = %A" foundNode



    printfn "Number (%i) is in tree: %O" searchNumber (NumberIsInTree searchNumber)

    Console.ReadKey() |> ignore
   
    0 // return an integer exit code
