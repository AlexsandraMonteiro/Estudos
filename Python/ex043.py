*'''Exercício Python 43: Desenvolva uma lógica que leia o peso e a altura de uma pessoa, calcule seu Índice de Massa Corporal (IMC) e mostre seu status, de acordo com a tabela abaixo:*

*– IMC abaixo de 18,5: Abaixo do Peso*
*– Entre 18,5 e 25: Peso Ideal*
*– 25 até 30: Sobrepeso*
*– 30 até 40: Obesidade*
*– Acima de 40: Obesidade Mórbida*'''

peso = float(input("Qual seu peso? (Kg)"))
alt = float(input("Qual sua altura? (m)"))
imc = peso / (alt ** 2)

print(f"Seu IMC é de {imc :.1f}")

if imc < 18.5:
    print("Você está ABAIXO DO PESO")
elif imc <= 25:
    print("Você está no PESO IDEAL")
elif imc <= 30:
    print("Você está em SOBREPESO")
elif imc <= 40:
    print("Você está em OBESIDADE")
else:
    print("Você está em OBESIDADE MÓRBIDA")