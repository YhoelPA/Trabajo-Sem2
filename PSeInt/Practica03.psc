Algoritmo Practica03
	Definir sue_bru, desc, sue_net, por_desc Como Real
	
    Escribir "Ingrese el sueldo bruto del trabajador:"
    Leer sue_bru
	
    Si sue_bru > 3000 Entonces
        por_desc = 0.13
    Sino
        por_desc = 0.11
    FinSi
	
    desc = sue_bru * por_desc
    sue_net = sue_bru - desc
	
    Escribir "El porcentaje de descuento aplicado es: ", por_desc * 100, "%"
    Escribir "El monto descontado por AFP es: S/ ", desc
    Escribir "El sueldo neto del trabajador es: S/ ", sue_net
	
FinAlgoritmo