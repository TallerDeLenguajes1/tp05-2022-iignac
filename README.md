# Trabajo Práctico 5
Muñoz Quiroga David Ignacio


## ¿String es un tipo por valor o un tipo por referencia?
Es un tipo por referencia

## ¿Qué secuencias de escape tiene el tipo string?
\'	Comilla simple	
\"	Comilla doble	
\\	Barra diagonal inversa	
\0	Null	
\a	Alerta	
\b	Retroceso	
\f	Avance de página
\n	Nueva línea	
\r	Retorno de carro	
\t	Tabulación horizontal	
\v	Tabulación vertical	0x000B
\u	Secuencia de escape Unicode (UTF-16)
\U	Secuencia de escape Unicode (UTF-32)
\x	Secuencia de escape Unicode similar a "\u" excepto con longitud variable

## ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?
Los caracteres especiales @ y $ son caracteres contextuales predefinidos que modifican el elemento de programa (una cadena literal, un identificador o un nombre de atributo) para que se antepongan. 

@, carácter de identificador textual. Se puede usar de estas formas:
1- Para habilitar el uso de palabras clave de C# como identificadores.
2- Para indicar que un literal de cadena se debe interpretar literalmente.
3- Para permitir que el compilador distinga entre los atributos en caso de conflicto de nomenclatura.

$, carácter de cadena interpolada: Permite insertar valores en una cadena o concatenar (unir entre sí) varias cadenas.