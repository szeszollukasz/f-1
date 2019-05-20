module File10

let rec func (x : int) =
    
    if (x < 0) then
        false
    elif (x / 4 >= 0 && x % 1 = 0 ) then
        true
    elif (x / 4 >= 0 && x % 3 = 0 ) then
        false
    elif (x / 2 = 0 && x % 2 = 0 ) then
        func (x / 2)
    else false