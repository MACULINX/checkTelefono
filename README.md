# checkTelefono
 
CheckTelefono, un algoritmo che dato un array di stringhe contenente numeri di telefono, restituisce il primo numero di telefono italiano valido

## Descrizione del programma

#### Controllo dei caratteri

```c#
for(int i=0 ; i < input.Length ; i++)
    foreach (char c in input[i])
        if(!char.IsDigit(c) && c != '+')
            input[i] = "Non Valido";
```

Quando il metodo riceve l'array di stringhe, viene fatta una selezione di quest'ultime.
Il ciclo FOR passa al FOREACH una stringa per volta, il quale controlla tramite un semplice IF che non siano presenti caratteri diversi da numeri o dal '+'
Nel caso dovesse trovare un carattere diverso da quelli sopra citati cambia il contenuto della stringa in "Non Valido" per evitare che vadi in conflitto con il controllo successivo 


#### Controllo del numero
```c#
for(int i=0 ; i < input.Length ; i++)
    if(((input[i].Length == 14) && (input[i][0] == '0') && (input[i][4]  == '3')) ||
       ((input[i].Length == 13) && (input[i][0] == '+') && (input[i][4]  == '3')) || 
       ((input[i].Length == 10) && (input[i][0]  == '3'))) 
        return input[i];
```
Finito il controllo precedente le stringhe rientrano all'interno di un ciclo FOR, dove pero' questa volta viene fatto un controllo sulla lunghezza della stringa (``` input[i].Length == xx ```), viene controllato che il primo carattere e' un  possibile prefisso(``` input[i][0] == 'x' ```) ed infine viene controllata la prima cifra del numero (``` input[i][0]  == '3' ```).
<br>
Se durante il controllo ci dovesse essere un numero valido il programma tornera' il primo che trova