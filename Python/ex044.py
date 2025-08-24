'''*Exercício Python 44: Elabore um programa que calcule o valor a ser pago por um produto, considerando o seu preço normal e condição de pagamento:*

*– à vista dinheiro/cheque: 10% de desconto*
*– à vista no cartão: 5% de desconto*
*– em até 2x no cartão: preço formal*
*– 3x ou mais no cartão: 20% de juros*'''

print("-=-" * 4)
print("LOJA DA ALÊ")
print("-=-" * 4)

preço = float(input("Preço da compra: R$"))
print('''ESCOLHA UMA FORMA DE PAGAMENTO
[1] à vista dinheiro/cheque
[2] à vista cartão
[3] 2x no cartão
[4] 3x ou mais no cartão''')
opção = int(input("Qual sua opção? "))

if opção == 1:
    desconto = preço - (preço * 10 / 100)
    print(f"Sua compra com desconto de 10% custará R${desconto :.2f}")
elif opção == 2:
    desconto = preço - (preço * 5 / 100)
    print(f"Sua compra com desconto de 5% custará R$ {desconto :.2f}")
elif opção == 3:
    parcela = preço / 2
    print(f"Sua compra será parcelada em 2x de R${parcela :.2f} SEM JUROS.")
elif opção == 4:
    juros = preço + (preço * 20 / 100)
    totparc = int(input("Quantas parcelas? "))
    parcela = juros / totparc
    print(f"Sua compra será parcela em {totparc}x de R${parcela :.2f} COM JUROS.")
else:
    print("OPÇÃO INVÉLIDA de pagamento, TENTE NOVAMENTE!")