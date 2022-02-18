' Il modello di elemento Pagina vuota è documentato all'indirizzo https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x410

''' <summary>
''' Pagina vuota che può essere usata autonomamente oppure per l'esplorazione all'interno di un frame.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page
    Private Sub Me_Load(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        ElementSoundPlayer.State = ElementSoundPlayerState.On
    End Sub

    Private Sub Back_Click(sender As Object, e As RoutedEventArgs) Handles Back.Click
        WebView21.GoBack()
    End Sub

    Private Sub Next_Click(sender As Object, e As RoutedEventArgs) Handles Nextly.Click
        WebView21.GoForward()
    End Sub


    Private Sub BCTV_Click(sender As Object, e As RoutedEventArgs) Handles BCTV.Click
        WebView21.Source = New Uri("https://www.betacloudtv.tech.blog")
        ElementSoundPlayer.Play(ElementSoundKind.Invoke)
    End Sub

    Private Sub BCsoft_Click(sender As Object, e As RoutedEventArgs) Handles BCsoft.Click
        WebView21.Source = New Uri("https://betacloudsoftware.wordpress.com/")

    End Sub

    Private Sub Downloadc_Click(sender As Object, e As RoutedEventArgs) Handles Downloadc.Click
        WebView21.Source = New Uri("https://betacloud.tech.blog/updated-cloud-links/")

    End Sub
    Private Sub AboutUWP_Click(sender As Object, e As RoutedEventArgs) Handles AboutUWP.Click
        WebView21.NavigateToString("<p>About <br> <br> <b>This UWP app is developed by RIXOLINO <br> <br> <br> <br> © BetaCloud Corp 2020-2022 </b></p>")
    End Sub

    Private Sub HomeBC_Click(sender As Object, e As RoutedEventArgs) Handles HomeBC.Click
        WebView21.Source = New Uri("https://betacloud.tech.blog/")
    End Sub

    Private Sub A_Click(sender As Object, e As RoutedEventArgs) Handles A.Click
        Core.CoreApplication.Exit()
    End Sub

    Private Sub FullView_Click(sender As Object, e As RoutedEventArgs) Handles FullView1.Click
        Dim view = ApplicationView.GetForCurrentView()

        If view.IsFullScreenMode Then
            view.ExitFullScreenMode()
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.Auto
        Else

            If view.TryEnterFullScreenMode() Then
                ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.FullScreen
            End If
        End If
    End Sub
End Class
