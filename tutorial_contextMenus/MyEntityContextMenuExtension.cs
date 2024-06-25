using System.ComponentModel.Composition;
using Mendix.StudioPro.ExtensionsAPI.Model;
using Mendix.StudioPro.ExtensionsAPI.Model.DomainModels;
using Mendix.StudioPro.ExtensionsAPI.UI.Menu;
using Mendix.StudioPro.ExtensionsAPI.UI.Services;

namespace MyCompany.MyProject.MendixExtension;

[method: ImportingConstructor]
[Export(typeof(ContextMenuExtension<>))]
class MyEntityContextMenuExtension(IMessageBoxService messageBoxService) : ContextMenuExtension<IEntity>
{
    MenuViewModel? disabledMenu;

    public override IEnumerable<MenuViewModel> GetContextMenus(IEntity entity)
    {
        var nudgeDownLeft = new MenuViewModel("Left", () => NudgeIt(entity, right: false, down: true));
        var nudgeDownLeftRight = new MenuViewModel("Right", () => NudgeIt(entity, right: true, down: true) );
        var nudgeDown = new MenuViewModel("Down", [nudgeDownLeft, nudgeDownLeftRight]);

        var nudgeUpLeft = new MenuViewModel("Left", () => NudgeIt(entity, right: false, down: false));
        var nudgeUpRight = new MenuViewModel("Right", () => NudgeIt(entity, right: true, down: false));
        var nudgeUp = new MenuViewModel("Up", [nudgeUpLeft, nudgeUpRight])
        {
            Separator = MenuSeparator.Before
        };

        yield return new MenuViewModel("Nudge it!", [nudgeDown, nudgeUp]);

        // new group
        var randomRenameString = new MenuViewModel("Random string", () => RenameEntity(entity, number: false));
        var randomRenameNumber = new MenuViewModel("Random number", () => RenameEntity(entity, number: true));

        yield return new MenuViewModel("Randomly rename", [randomRenameString, randomRenameNumber]);

        // show location
        yield return new MenuViewModel("Show location", () => ShowLocation(entity, messageBoxService));

        var showName = new MenuViewModel("Show current name", () => messageBoxService.ShowInformation(entity.Name));
        // "Randomly rename" was added previously, thus it will trigger an exception when collected if uncommented
        //yield return new MenuViewModel("Randomly rename", [showName]);

        // Enabling a disabled menu
        disabledMenu ??= new MenuViewModel("Disabled menu", () =>
        {
            messageBoxService.ShowInformation("I'm enabled now. But not for long!");
            disabledMenu!.IsEnabled = false;
        }){ IsEnabled = false };
        var enablingMenu = new MenuViewModel("Enable disabled menu", () => disabledMenu.IsEnabled = true );

        yield return new MenuViewModel("Enabling menus", [disabledMenu, enablingMenu]);
    }

    void NudgeIt(IEntity entity, bool right, bool down)
    {
        var incrementRight = right ? 20 : -20;
        var incrementDown = down ? 20 : -20;
        using var transaction = CurrentApp!.StartTransaction("nudge with context menu");
        entity.Location = new Location(entity.Location.X + incrementRight, entity.Location.Y + incrementDown);

        transaction.Commit();
    }

    void RenameEntity(IEntity entity, bool number)
    {
        using var transaction = CurrentApp!.StartTransaction("rename with context menu");

        entity.Name = number ? $"E_{new Random().Next()}" : $"E_{Guid.NewGuid().ToString().Replace("-", "")}";

        transaction.Commit();
    }

    static void ShowLocation(IEntity entity, IMessageBoxService messageBoxService) => messageBoxService.ShowInformation($"X: {entity.Location.X}, Y: {entity.Location.Y}");
}
