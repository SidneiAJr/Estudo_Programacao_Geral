<?php

interface VerificarPersonagem{
    public function VeriPersona():void;
    public function VerificaHP():void;
    public function VerificaStatus():void;
    public function VerificaLevel():void;
}

interface VerificarItens{

}

interface VerificaHabilidade{

}

interface VerificaClasse{

}

abstract class Classe implements VerificarPersonagem, VerificaHabilidade, VerificaClasse{
   public function __construct(public string $NomePersonagem,public int $DanoPersonage, public string $InfoPersonagem) {}
}

class Personagem extends Classe implements VerificaClasse, VerificarPersonagem,VerificaHabilidade{
    public function VerificaHP(): void
    {
        
    }
    public function VeriPersona(): void
    {
        
    }
    public function VerificaStatus(): void
    {
        
    }
    public function VerificaLevel(): void
    {
        
    }
}


?>
