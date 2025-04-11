Algoritmo Practica01
    definir nomb Como Caracter
    definir pre, igv, total como real
    
	mon = 0.18
    
    Escribir "Ingrese el nombre del producto: "
    Leer nomb	
    
    Escribir "Ingrese el precio del producto: "
    leer pre
    
    igv = pre * mon
    total = pre + igv
    
    Escribir "Producto: ", nomb
    Escribir "Precio base: S/", pre
    Escribir "IGV (18%): S/", igv
    Escribir "Total a pagar: S/", total
	
FinAlgoritmo