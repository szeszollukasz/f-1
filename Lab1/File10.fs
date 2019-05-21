module File10

let rec func (k : int) =
    
    if (k < 0) then
        false
    elif (k / 4 > 0 && k % 1 = 0 ) then
        true
    elif (k / 4 > 0 && k % 3 = 0 ) then
        false
    elif (k / 2 = 1 && k % 2 = 0 ) then
        func (k * 2)
    else false