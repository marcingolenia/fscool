module SpaceAge

type Planet = Earth | Mercury | Venus | Mars | Jupiter | Saturn | Uranus | Neptune

let earthAgeInYears seconds = 
    float seconds / float 31557600

let age planet (seconds: int64) = 
    let earthAges = earthAgeInYears seconds
    match planet with
    | Earth -> earthAges
    | Mercury -> earthAges / 0.2408467
    | Venus -> earthAges / 0.61519726
    | Mars -> earthAges / 1.8808158
    | Jupiter -> earthAges / 11.862615
    | Saturn -> earthAges / 29.447498
    | Uranus -> earthAges / 84.016846
    | Neptune -> earthAges / 164.79132 