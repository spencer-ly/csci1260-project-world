1.) Explain your two diamonds: *solid diamond* Character "has a" CharacterStyle. When a character is created, it needs a style (skin, color, eyes) to go with it. if emoved
    it goes away with it. *hollow* CharacterManager and Character have a CostumePiece. Program creates them, gets passed to manager using Add and then to the character with Wear.
2.) Justify interface: CharacterItem, CostumePiece, Character, Feet, HeadPiece, and Outfit all use IDescribable. It overrides the child classes from base class (CharacterItem).
    This is done by assigning different details to different costume pieces.
3.) Adding a new kind: If i were to add a Hand class where the character could hold a sword, weapon, rose, etc, the manager would still remain the same as it's 
still added into the List<CostumePiece> thru it. I would create a Hand class and add it to Program thru a new CostumePiece.

Video: https://etsu365-my.sharepoint.com/:v:/g/personal/lynnsm_etsu_edu/IQBYHb4SAe9_TJmqHFsyp41gAdQ4NBuzZ1obNjd-POis2uQ?nav=eyJyZWZlcnJhbEluZm8iOnsicmVmZXJyYWxBcHAiOiJPbmVEcml2ZUZvckJ1c2luZXNzIiwicmVmZXJyYWxBcHBQbGF0Zm9ybSI6IldlYiIsInJlZmVycmFsTW9kZSI6InZpZXciLCJyZWZlcnJhbFZpZXciOiJNeUZpbGVzTGlua0NvcHkifX0&e=3p6a9T
