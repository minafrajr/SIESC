#region Cabeçalho
// Projeto:SIESC_BD
// Autor:Carlos A. Minafra Jr.
// Criado em: 22/03/2015
#endregion
namespace SIESC_BD.Properties {
    
    
    // Esta classe permite que você manipule eventos específicos na classe de configurações:
    //  O evento SettingChanging é gerado antes da alteração de um valor de configuração.
    //  O evento PropertyChanged é gerado depois da alteração de um valor de configuração.
    //  O evento SettingsLoaded é gerado depois do carregamento dos valores de configuração.
    //  O evento SettingsSaving é gerado antes de salvar os valores de configuração.
    internal sealed partial class Settings {
        private void SettingChangingEventHandler(object sender, System.Configuration.SettingChangingEventArgs e) {
            // Adicione código para manipular o evento SettingChangingEvent aqui.
        }
        
        private void SettingsSavingEventHandler(object sender, System.ComponentModel.CancelEventArgs e) {
            // Adicione código para manipular o evento SettingsSaving aqui.
        }
    }
}
