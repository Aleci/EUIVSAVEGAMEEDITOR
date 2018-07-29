using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.model.provinces
{
    class Provinces
    {
        int id;
        String name;
        String owner;
        String controller;
        String previous_controller;
        List<float> institutions;
        String cores;
        String trade;
        List<Unit> unit;
        List<SpyActions> spyActions;
        String original_culture;
        String culture;
        String religion;
        String original_religion;
        String capital;
        String is_city;
        float garrison;
        float base_tax;
        float original_tax;
        float base_production;
        float base_manpower;
        String likely_rebels;
        String trade_goods;
        bool ub;
        List<history> history;
        int patrol;
        List<DiscoveryDates2> discovery_dates2;
        List<DiscoveryReligionDates2> discovery_religion_dates2;
        List<string> discovered_by;
        int native_hostileness;
        int native_ferocity;
        int winter;
        int previous_winter;
        List<DiplomacyConstruction> diplomacy_construction;
        float trade_power;
        List<RebelFaction> rebel_faction;
        float hostile_core_creation_cost;
        string hostile_core_creation_tag;
        string hostile_core_creation_desc;
    }

}
