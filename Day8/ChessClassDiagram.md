```mermaid
    classDiagram

        class GameStatus {
            <<enum>>
            Active
            BlackWin
            WhiteWin
            Stalemate
            Resignation
        }

        class PieceColor {
            <<enum>>
            White
            Black
        }

        class IPlayer {
            <<interface>>
            +String PlayerName
            +List<IPiece> Pieces

            +bool IsChecked()
        }

        class IPiece {
            <<interface>>
            +bool Killed 
            +PieceColor PieceColor

            +bool IsKilled()
            +bool CanMove()
        }

        class Box {
            +int X 
            +int Y

            +int GetX()
            +int GetY()
        }

        class Piece {
            +bool Killed
            +PieceColor PieceColor

            +bool IsKilled()
            +bool CanMove()
        }

        class King {
            +bool CastlingDone

            +bool CanMove()
        }

        class Queen {
            +bool CanMove()
        }

        class Bishop {
            +bool CanMove()
        }

        class Knight {
            +bool CanMove()
        }
        
        class Rook {
            +bool CanMove()
        }

        class Pawn {
            +bool EnPassant
            +bool CanPromote

            +bool CanMove()
            +void SetEnPassant()
            +void SetCanPromote()
        }

        class Player {
            +String PlayerName
            +List<IPiece> Pieces

            +bool IsChecked()
        }

        class Board {
            +Box[ , ] Boxes

            +list<IPiece> GetPieces()
            +IPiece GetPieceAt(Box position)
        }

        class GameController {
            +Action<List<Move>> OnMovesPlayedHistory
            +List<Move> MovesPlayer
            +Dictionary<IPlayer, List<IPiece>> PlayerPieceDictionary
            +GameStatus Status
            +IPlayer CurrentTurn
            +IPiece PieceKilled
            
            +bool ValidateMove(Move move)
            +bool MakeMove(Move move)
            +bool IsOver()
            +bool PlayerMove()
            +void SetPlayerGameStatus()
            +bool CheckEnPassant(Move move)
            +bool CheckPromotion(Move move)
            +void SwitchTurn()
        }

        class ValidatorMoving {
            +IPlayer Player
            +IPiece Piece
            +Box StartBox
            +Box EndingBox
            +bool IsCastling
            +bool IsPromotion
            +bool IsEnPassant

            +void SetCastlingMove()
        }

        class Display {
            +bool DisplayMove()
        }

        GameController --> Display
        GameController --> Board
        GameController --> Box
        GameController --> IPiece
        GameController --> IPlayer
        GameController --> ValidatorMoving

        ValidatorMoving --> Board

        Player --> IPlayer

        Board --> Box
        Board --> Piece

        Piece --> IPiece

        Piece <|-- King
        Piece <|-- Queen
        Piece <|-- Bishop
        Piece <|-- Knight
        Piece <|-- Rook
        Piece <|-- Pawn

```
