﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Sitecore.Foundation.Common.Specflow.Infrastructure;
using Sitecore.Foundation.Common.Specflow.Service_References.UtfService;
using TechTalk.SpecFlow;

namespace Sitecore.Foundation.Common.Specflow.Steps
{
  [Binding]
  public class CompatibleRenderingsSteps : StepsBase
  {
    [Then(@"(.*) module contains incompatible renderings")]
    public void ThenModuleContainsIncompatibleRenderings(string module, Table table)
    {
      var items = table.Rows.Select(x => x.Values.First());

      foreach (var item in items)
      {
        var renderingPath = ItemService.GetModuleRenderingPath(module, item);
        var itemFieldValue = ContextExtensions.UtfService.GetItemFieldValue(renderingPath, "Compatible Renderings", Database.Master);
        itemFieldValue.Should().BeEmpty();
      }


    }

    [Then(@"(.*) module contains compatible renderings")]
    public void ThenModuleContainsCompatibleRenderings(string module, Table table)
    {
      var items = table.Rows.Select(x => x.Values.First());
      var renderings = items.Select(x => ItemService.GetModuleRenderingPath(module, x)).Select(x => new
      {
        Path = x,
        Id = ContextExtensions.UtfService.ItemExistsByPath(x, Database.Master)
      }).ToList();
      foreach (var rendering in renderings)
      {
        var otherRenderings = renderings.Where(x => x.Id != rendering.Id);
        var compatibleRenderings = ContextExtensions.UtfService.GetItemFieldValue(rendering.Path, "Compatible Renderings", Database.Master);
        var compatibleRenderingIds = compatibleRenderings.Split(new[] {'|'}, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim());

        compatibleRenderingIds.Should().BeEquivalentTo(otherRenderings.Select(x=>x.Id));
      }
    }
  }





}
