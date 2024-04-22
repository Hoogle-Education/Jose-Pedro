# Relacionamentos em POO

## Composição

- tem um

```cs
public class Arco {
  public int NumeroDeFlechas {get; set;}
}

public class Arqueiro {
  public Arco Arco {get; set;}
}
```

- tem muitos

```cs
public class Habilidade {
  public string Nome {get; set;}
  public int Dano {get; set;}
}

public class Arqueiro {
  public List<Habilidade> Habilidades {get; set;}
}
```

consequencias:

- tem um + tem um = um pra um
- tem um + tem muitos = um pra muitos
- tem muitos + tem muitos = muitos pra muitos

## Herança

Reutiliza atributos e métodos de uma classe mãe

```cs
public class Player {
  public int Vida {get; set;}
  public int Ataque {get; set;}
  public int Defesa {get; set;}

  public virtual void Atacar(Player playerAlvo) {
    int DanoCausado = Ataque - playerAlvo.Defesa;

    if(DanoCausado > 0)
      playerAlvo.Vida -= DanoCausado;
  }

}

public class Lutador : Player {

  public int AtaqueDaArma { get; set; }

  public override void Atacar(Player playerAlvo) {
    int DanoCausado = Ataque + AtaqueDaArma - playerAlvo.Defesa;

    if(DanoCausado > 0)
      playerAlvo.Vida -= DanoCausado;
  }

}
```

## sobreescrevendo metodos (`vitual` + `override`)

`virtual` abre um metodo para ser sobreescrito pelas classes filhas.

`override` eh usado na classe filha para sobreescrever um metodo.

- podemos encerrar uma `virtual`:

`sealed` signfica 'selado' e faz com que o método não possa mais ser sobreescrito.

## upcasting e downcasting

- upcasting(*seguro*): mencionar uma classe filha como sua classe mae

```cs
Player p1 = new Lutador();
Player p2 = new Arqueiro();

p1.Atacar(p2);

// List<Player> players = new List<Player>();
List<Player> players = new();

player.Add(new Arqueiro());
player.Add(new Mago());
player.Add(new Lutador());
```

- downcasting(*inseguro*): mencionar uma classe mae como sua classe filha

```cs
Player p1 = new Arqueiro();

// p1.Arco nao funcionaria pois estou tratando como Player

Arqueiro a1 = (Arqueiro) p1;

// downcasting seguro

if (p1 is Arqueiro a1) {
  // Arqueiro a1 = (Arqueiro) p1;
  a1.Arco.NumeroDeFlechas += 10;
}
```
