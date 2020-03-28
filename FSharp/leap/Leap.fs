module Leap

let leapYear (year: int): bool =
    let ``Is Divisible by 4`` = (year % 4) = 0
    let ``Is Divisible by 100`` = (year % 100) = 0
    let ``Is Divisible by 400`` = (year % 400) = 0
    (``Is Divisible by 4`` &&  not ``Is Divisible by 100``)
    || (``Is Divisible by 4`` && ``Is Divisible by 100`` && ``Is Divisible by 400``)