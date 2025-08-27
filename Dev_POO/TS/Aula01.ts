type Carro = {
    nome: string;
    ano: string;
    preco: string;
    documento: boolean;
    tem_motor: boolean;
    motor: number;
};

const carro: Carro = {
    nome: "Uno",
    ano: "2000",
    preco: "5000",
    documento: true,
    tem_motor: true,
    motor: 1.0
};

console.log("Potência do motor:", carro.motor);
