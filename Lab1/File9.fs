module File9
let sort (list : int list) = List.sortBy (fun elem ->  -elem) list
