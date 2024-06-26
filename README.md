# How to set different row height for each row in Xamarin.Forms listview?

This example demonstrates how to set different row height for each row in Xamarin.Forms listview.

C# code snippet:
```
        // Wiring the event.
        listView.QueryItemSize += ListView_QueryItemSize;

        private void ListView_QueryItemSize(object sender, QueryItemSizeEventArgs e)
        {
            if (e.ItemIndex % 2 == 0)
                e.ItemSize = 50;
            else
                e.ItemSize = 100;
            e.Handled = true;
        }
```

See [How to set different row height for each row in Xamarin.Forms listview](https://www.syncfusion.com/kb/9478/how-to-set-different-row-height-for-each-row-in-listview) for more details.

## Requirements to run the demo

* [Visual Studio 2017](https://visualstudio.microsoft.com/downloads/) or [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/)
* Xamarin add-ons for Visual Studio (available via the Visual Studio installer).

## Troubleshooting

### Path too long exception

If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.
