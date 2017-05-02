module Node

type Node = { 
            Left:Option<Node>;
            Right:Option<Node>;
            Int:int 
        }

let rec getNode (node:Option<Node>) (n:int) =
    match node with 
    | None _ -> printfn "not found %i" n
                None    
    | Some x when x.Int=n -> printfn "found %i" n; 
                             node
    | Some x when x.Int<n -> printfn  "search value %i greater than %i" n x.Int;
                             getNode x.Right n                                  
    | Some x when x.Int>n -> printfn  "search value %i less than %i" n x.Int;
                             getNode x.Left n                                   
    | Some _ -> None


let rec findNode (node:Option<Node>) (n:int) =
    match node with 
    | None _ -> printfn "not found %i" n
                false     
    | Some x when x.Int=n -> printfn "found %i" n; 
                             true
    | Some x when x.Int<n -> printfn  "search value %i greater than %i" n x.Int;
                             findNode x.Right n                                  
    | Some x when x.Int>n -> printfn  "search value %i less than %i" n x.Int;
                             findNode x.Left n                                   
    | Some _ -> false
 

