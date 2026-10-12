namespace AviGestion_.Seguridad
{
    // Dígito verificador simple (CU-08): detecta si un Código de producto
    // fue alterado directamente en la base de datos, por fuera del sistema.
    public static class DigitoVerificador
    {
        public static int Calcular(string codigo)
        {
            if (string.IsNullOrEmpty(codigo)) return 0;

            int suma = 0;
            for (int i = 0; i < codigo.Length; i++)
            {
                suma += (i + 1) * (int)codigo[i];
            }
            return suma % 10;
        }

        public static bool Validar(string codigo, int digitoAlmacenado)
        {
            return Calcular(codigo) == digitoAlmacenado;
        }
    }
}