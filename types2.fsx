type Suit = | Spades | Clubs | Diamonds | Hearts // Union type is choice - pick one 
  
type Face = | Two  | Three | Four  | Five
            | Six  | Seven | Eight | Nine | Ten
            | Jack | Queen | King  | Ace
  
type Card = Face * Suit // Tuple means pair, so card has a face and suit.
type Deck = Card list  // built in list type
let suits = [Spades; Clubs; Diamonds; Hearts]
let faces = [Two; Three; Four; Five; Six; Seven; Eight; Nine; Ten; Jack; Queen; King; Ace]
let deck = [for suit in suits do
            for face in faces do
                yield face, suit]

printfn "%A" deck