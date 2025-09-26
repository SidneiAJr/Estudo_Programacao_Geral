<?php

interface VerificarPersonagem{
    public function VeriPersona():void;
    public function VerificaHP():void;
    public function VerificaStatus():void;
    public function VerificaLevel():void;
}

interface VerificarItens{
    public function Itens():void;
    public function ItensCertos():bool;
}

interface VerificaHabilidade{

}

interface VerificaClasse{

}

abstract class Classe implements VerificarPersonagem, VerificaHabilidade, VerificaClasse{
   public function __construct(public string $NomePersonagem,public int $DanoPersonage, public string $InfoPersonagem,public string $tipoIten) {}
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
class Itens implements VerificarItens{
    public function Itens(): void
    {
        
    }
    public function ItensCertos(): bool
    {
        if($this->$tipoIten=="Espada"){
           echo "Erro";
        }else{
            echo "Item Errado";
        }
        return $tipoIten;
    }
}


?>
