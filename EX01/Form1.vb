Public Class Form1
    Dim primeiroNum As Decimal      'declarar as variaveis a ser utilizadas
    Dim segundoNum As Decimal
    Dim operacao As Integer         'operaçao corresponde as operações a serem feitas
    Dim operador As Boolean = False 'é a operação, está assinalado como booleano 


    Private Sub btnN1_Click(sender As Object, e As EventArgs) Handles btnN1.Click
        If txtEcra.Text <> "0" Then
            txtEcra.Text += "1"     'atribui-se a tecla o número 1
        Else                        'o += serve para acrescentar o numero pedido
            txtEcra.Text = "1"
        End If
    End Sub

    Private Sub btnN2_Click(sender As Object, e As EventArgs) Handles btnN2.Click
        If txtEcra.Text <> "0" Then
            txtEcra.Text += "2"     'atribui-se a tecla o número 2
        Else
            txtEcra.Text = "2"
        End If
    End Sub

    Private Sub btnN3_Click(sender As Object, e As EventArgs) Handles btnN3.Click
        If txtEcra.Text <> "0" Then
            txtEcra.Text += "3"
        Else
            txtEcra.Text = "3"
        End If
    End Sub

    Private Sub btnN4_Click(sender As Object, e As EventArgs) Handles btnN4.Click
        If txtEcra.Text <> "0" Then
            txtEcra.Text += "4"
        Else
            txtEcra.Text = "4"

        End If
    End Sub

    Private Sub btnN5_Click(sender As Object, e As EventArgs) Handles btnN5.Click
        If txtEcra.Text <> "0" Then
            txtEcra.Text += "5"
        Else
            txtEcra.Text = "5"

        End If
    End Sub

    Private Sub btnN6_Click(sender As Object, e As EventArgs) Handles btnN6.Click
        If txtEcra.Text <> "0" Then
            txtEcra.Text += "6"
        Else
            txtEcra.Text = "6"
        End If
    End Sub

    Private Sub btnN7_Click(sender As Object, e As EventArgs) Handles btnN7.Click
        If txtEcra.Text <> "0" Then
            txtEcra.Text += "7"
        Else
            txtEcra.Text = "7"
        End If
    End Sub

    Private Sub btnN8_Click(sender As Object, e As EventArgs) Handles btnN8.Click
        If txtEcra.Text <> "0" Then
            txtEcra.Text += "8"
        Else
            txtEcra.Text = "8"
        End If
    End Sub

    Private Sub btnN9_Click(sender As Object, e As EventArgs) Handles btnN9.Click
        If txtEcra.Text <> "0" Then
            txtEcra.Text += "9"
        Else
            txtEcra.Text = "9"
        End If
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        If txtEcra.Text <> "0" Then
            txtEcra.Text += "0"
        End If
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        txtEcra.Clear()         'limpa o ecrâ
        txtEcra.Text = "0"      'atribui ao ecra o 0 inicial
    End Sub

    Private Sub btnVirg_Click(sender As Object, e As EventArgs) Handles btnVirg.Click
        If Not (txtEcra.Text.Contains(",")) Then
            txtEcra.Text += ","         'atribui a tecla "," a expressão contains serve para não deixar por mais que uma virgula
        End If
    End Sub

    Private Sub btnSomar_Click(sender As Object, e As EventArgs) Handles btnSomar.Click
        primeiroNum = txtEcra.Text
        txtEcra.Clear()
        txtEcra.Text = "0"
        operador = True
        operacao = 1
    End Sub

    Private Sub btnSubtrair_Click(sender As Object, e As EventArgs) Handles btnSubtrair.Click
        primeiroNum = txtEcra.Text
        txtEcra.Clear()
        txtEcra.Text = "0"
        operador = True
        operacao = 2
    End Sub

    Private Sub btnMultiplicar_Click(sender As Object, e As EventArgs) Handles btnMultiplicar.Click
        primeiroNum = txtEcra.Text      'primeiro numero corresponde ao que se encontra no ecra antes do operador
        txtEcra.Clear()
        txtEcra.Text = "0"
        operador = True                 'operador selecionado 
        operacao = 3                    'atribui-se um identificador à operação
    End Sub

    Private Sub btnDividir_Click(sender As Object, e As EventArgs) Handles btnDividir.Click
        primeiroNum = txtEcra.Text
        txtEcra.Clear()
        txtEcra.Text = "0"
        operador = True
        operacao = 4

    End Sub

    Private Sub btnResultado_Click(sender As Object, e As EventArgs) Handles btnResultado.Click
        If operador = True Then
            segundoNum = txtEcra.Text
            If operacao = 1 Then            'Soma
                txtEcra.Text = primeiroNum + segundoNum
            ElseIf operacao = 2 Then        'Subtração
                txtEcra.Text = primeiroNum - segundoNum
            ElseIf operacao = 4 Then        'Multiplicação
                txtEcra.Text = primeiroNum * segundoNum
            Else
                If segundoNum = 0 Then      'erro de divisão ao se dividir por 0
                    txtEcra.Text = "Erro"
                Else txtEcra.Text = primeiroNum / segundoNum        'Divisão
                End If
            End If
            operador = False
        End If
    End Sub
End Class
