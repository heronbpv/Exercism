let leapYear (year: int) =
    let ``Is Divisible by 4`` = sprintf "%b" ((year % 4) = 0)
    let ``Is Divisible by 100`` = sprintf "%b" ((year % 100) = 0)
    let ``Is Divisible by 400`` = sprintf "%b" ((year % 400) = 0)
    printfn "by 4?: %s by 100?:%s by 400?:%s" ``Is Divisible by 4`` ``Is Divisible by 100`` ``Is Divisible by 400``
    //``Is Divisible by 4`` && ``Is Divisible by 100`` && ``Is Divisible by 400``

let leapYear2 (year: int) =
    if ((year % 4) = 0) then
        if ((year % 100) = 0) then
            if ((year % 400) = 0) then
                true
             else
                 false
        else
            true
    else
        false


leapYear 1996
leapYear2 1996
leapYear 1960
leapYear2 1960