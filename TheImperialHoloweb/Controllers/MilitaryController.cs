using Microsoft.AspNetCore.Mvc;
using TheImperialHoloweb.Models.Military;

namespace TheImperialHoloweb.Controllers
{
    public class MilitaryController : Controller
    {
        public IActionResult About()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Applications()
        {
            return View(new MilitaryApplicationViewModel());
        }

        [HttpPost]
        public IActionResult Applications(MilitaryApplicationViewModel model)
        {
            // TODO: Save to database
            return View(model);
        }

        public IActionResult Occupations()
        {
            return View();
        }

        public IActionResult Armory()
        {
            // TODO: Replace with ApplicationDbContext query once DB table is set up
            var items = new List<ArmoryItemViewModel>
            {
                new() {
                    Id = 1, Name = "E-11 Blaster Rifle", Type = "Firearm", Faction = "Imperial",
                    Synopsis = "Standard-issue blaster rifle of the Imperial Stormtrooper Corps, built for reliability across all environments.",
                    Description = "The E-11 blaster rifle, manufactured by BlasTech Industries under Imperial contract, is the primary small arm of the Stormtrooper Corps. Its gas conversion module and compact power cell allow sustained combat operations without resupply, while its integrated scope provides effective target acquisition at medium range. Reports questioning its accuracy under field conditions are attributed to deliberate disinformation campaigns by Rebel propaganda networks. The weapon has demonstrated superior performance across hundreds of engagement theaters, from the frozen tundras of Hoth to the desert wastelands of Tatooine."
                },
                new() {
                    Id = 2, Name = "DL-44 Heavy Blaster Pistol", Type = "Firearm", Faction = "Criminal / Rebel",
                    Synopsis = "Powerful civilian-grade heavy blaster pistol frequently found in the hands of smugglers, bounty hunters, and rebels.",
                    Description = "The DL-44, produced by BlasTech Industries, is a heavy blaster pistol whose power output far exceeds most civilian-permitted sidearms. While originally designed as a personal defense weapon for deep-space travelers, the DL-44 has become the weapon of choice for criminals, freelance operatives, and known Rebel Alliance members. Its rapid fire rate and devastating stopping power make it a threat in close-quarters combat, though its power cell depletes quickly under sustained fire. Imperial Security Bureau records indicate the DL-44 appears disproportionately in evidence logs from criminal arrests across the Outer Rim."
                },
                new() {
                    Id = 3, Name = "DC-15A Blaster Rifle", Type = "Firearm", Faction = "Imperial (Legacy)",
                    Synopsis = "Clone Wars-era precision blaster rifle retained in Imperial reserve armories and legacy garrison units.",
                    Description = "The DC-15A blaster rifle was the primary service weapon of the Grand Army of the Republic's clone trooper legions during the Clone Wars. While largely phased out in favor of the E-11 in front-line Stormtrooper units, the DC-15A remains in active use among reserve garrison forces and certain Outer Rim planetary defense battalions. Its longer barrel and high-powered plasma cell provide superior range compared to the E-11, though its size makes it less practical for rapid deployment scenarios. The DC-15A represents the institutional bridge between the Republic military that was and the Imperial force that is."
                },
                new() {
                    Id = 4, Name = "DLT-19 Heavy Blaster Rifle", Type = "Firearm", Faction = "Imperial",
                    Synopsis = "Long-range heavy blaster rifle used by Imperial heavy infantry and elite Stormtrooper units in sustained engagements.",
                    Description = "The DLT-19 heavy blaster rifle is a gas-powered rotary blaster capable of sustained automatic fire that far exceeds the output of the standard E-11. Issued to Imperial heavy infantry and specialized Stormtrooper detachments, the DLT-19 is designed for fire suppression, area denial, and engaging enemy emplacements at long range. Its rotating barrel assembly dissipates heat build-up that would otherwise limit burst duration, allowing near-continuous fire. The weapon's weight and ammunition consumption make it unsuitable as a general-issue weapon, but in the hands of a trained heavy weapons specialist, it can halt an enemy advance before it begins."
                },
                new() {
                    Id = 5, Name = "E-Web Heavy Repeating Blaster", Type = "Firearm", Faction = "Imperial",
                    Synopsis = "Crew-served tripod-mounted heavy repeating blaster deployed to fortify Imperial defensive positions.",
                    Description = "The E-Web heavy repeating blaster cannon is one of the most formidable anti-infantry and light-vehicle weapons in the Imperial arsenal. Requiring a two-person crew for optimal operation, the E-Web's sustained fire rate and penetrating power can suppress entire platoons and disable unshielded light vehicles. Its dedicated power generator and cooling vanes allow for extended engagements without interruption. Standard Imperial garrison protocol calls for E-Web emplacements at all primary defensive chokepoints. The weapon's distinctive silhouette has become synonymous with Imperial territorial control across the Outer Rim."
                },
                new() {
                    Id = 6, Name = "WESTAR-35 Blaster Pistol", Type = "Firearm", Faction = "Criminal",
                    Synopsis = "High-end blaster pistol favored by Mandalorian warriors and elite bounty hunters for its precision and durability.",
                    Description = "The WESTAR-35 is a blaster pistol manufactured by Concordia Armories specifically to meet the demanding performance requirements of Mandalorian combat traditions. Its phrik alloy barrel casing provides exceptional heat resistance, allowing rapid follow-up shots that would warp a standard pistol barrel. The weapon is frequently encountered in the hands of high-profile bounty hunters, Mandalorian warrior clans, and the criminal organizations that employ them. Imperial records classify it as a controlled weapon whose import to Core World systems requires documented justification, though enforcement along Outer Rim trade routes remains inconsistent."
                },
                new() {
                    Id = 7, Name = "TIE/LN Starfighter", Type = "Vehicle", Faction = "Imperial",
                    Synopsis = "The Empire's primary space superiority fighter, feared for its speed, twin ion engines, and relentless swarm tactics.",
                    Description = "The Twin Ion Engine Line starfighter, universally known as the TIE Fighter, is the workhorse of the Imperial Navy's starfighter corps. Manufactured by Sienar Fleet Systems, the TIE's lightweight construction — achieved by eliminating shields and a hyperdrive — allows for exceptional maneuverability and speed. Imperial doctrine calls for TIE fighters to operate in swarm formations, overwhelming enemy defenses through sheer numbers and coordinated attack patterns. Over fourteen thousand TIE-series fighters are in active deployment across the Imperial fleet at any given time, making it the most common warship in the galaxy and the first line of Imperial air and space superiority response in any engagement theater."
                },
                new() {
                    Id = 8, Name = "TIE Bomber", Type = "Vehicle", Faction = "Imperial",
                    Synopsis = "Heavy bomber variant of the TIE line, designed for orbital bombardment, capital ship assault, and mine deployment.",
                    Description = "The TIE/sa Bomber is a dual-pod heavy attack craft derived from the standard TIE airframe. One pod houses the pilot, life support, and drive systems, while the second is a weapons pod carrying proton bombs, concussion missiles, or space mines for varied mission profiles. The TIE Bomber is the Imperial Navy's primary platform for precision and saturation bombardment of surface targets, enemy capital ship sections, and deep-space installations. While slower and less maneuverable than the standard TIE Fighter, the Bomber operates under fighter escort in doctrine and rarely operates in contested airspace without dedicated cover."
                },
                new() {
                    Id = 9, Name = "Imperial-class Star Destroyer", Type = "Vehicle", Faction = "Imperial",
                    Synopsis = "The backbone of the Imperial Navy, a kilometer-long warship that symbolizes the absolute power of the Galactic Empire.",
                    Description = "The Imperial-class Star Destroyer, designed by Lira Wessex at Kuat Drive Yards, is the premier capital warship of the Galactic Empire. Stretching 1,600 meters from bow to stern, an Imperial I variant carries a full complement of 9,235 troops, 72 TIE fighters, two prefabricated garrison bases, and a devastating array of turbolaser batteries, ion cannons, and proton torpedo tubes. A single Star Destroyer can pacify an entire planet's surface from orbit. The mere presence of one in a system's space is sufficient to bring even entrenched resistance to negotiation. There are currently over 25,000 Imperial-class Star Destroyers in active commission across the galaxy."
                },
                new() {
                    Id = 10, Name = "AT-AT Walker", Type = "Vehicle", Faction = "Imperial",
                    Synopsis = "Towering heavy assault walker and the Empire's most feared ground combat vehicle, virtually immune to standard infantry fire.",
                    Description = "The All Terrain Armored Transport stands over 22 meters in height and is armored with durasteel plating capable of withstanding all but the heaviest anti-vehicle weaponry. The AT-AT is designed to crush enemy fortifications, demoralize opposing forces, and provide fire support to advancing Stormtrooper battalions. Its forward-mounted twin laser cannons and medium repeating blasters can engage targets across a wide arc. Imperial Army tacticians consider the psychological impact of an AT-AT assault to be as strategically significant as its considerable destructive capacity — enemy formations have been known to break and rout before an AT-AT walker has fired a single shot."
                },
                new() {
                    Id = 11, Name = "AT-ST Scout Walker", Type = "Vehicle", Faction = "Imperial",
                    Synopsis = "Two-legged light scout walker used for rapid reconnaissance, infantry support, and perimeter patrol of Imperial installations.",
                    Description = "The All Terrain Scout Transport is a lightweight two-legged combat walker used as a complement to heavier AT-AT deployments and as an independent reconnaissance and fire support platform. Its speed and low logistical profile make it ideal for rapid patrol operations across varied terrain. Armed with a chin-mounted twin blaster cannon and a concussion grenade launcher, the AT-ST can engage infantry and light vehicles effectively while maintaining the mobility to reposition quickly. Garrison commanders frequently deploy AT-STs in paired or squad formations to cover wide patrol perimeters around Imperial bases, landing platforms, and processing facilities."
                },
                new() {
                    Id = 12, Name = "X-Wing Starfighter (T-65B)", Type = "Vehicle", Faction = "Rebel",
                    Synopsis = "The Rebel Alliance's primary starfighter, equipped with four laser cannons and proton torpedo launchers.",
                    Description = "The Incom T-65B X-Wing was developed during the waning years of the Republic and subsequently appropriated by the criminal Rebel Alliance. Armed with four laser cannons, two proton torpedo launchers, and a full astromech droid socket for navigation and systems repair, the X-Wing presents a credible threat in one-on-one combat. Imperial analysts note that the vehicle's hyperdrive and shields increase its mass and limit maneuverability relative to TIE fighters in swarm doctrine. The craft was responsible for the destruction of the Death Star battle station through an exploited technical vulnerability, a deficiency since remediated in all subsequent Imperial superweapon engineering protocols."
                },
                new() {
                    Id = 13, Name = "YT-1300 Freighter (\"Millennium Falcon\")", Type = "Vehicle", Faction = "Criminal / Rebel",
                    Synopsis = "Heavily modified Corellian freighter operating outside the Imperial shipping registry, classified as a vessel of criminal interest.",
                    Description = "Registry: UNKNOWN. Classification: CRIMINAL AND REBEL ASSET. The vessel identified as the Millennium Falcon is a heavily modified Corellian Engineering Corporation YT-1300 light freighter operating in direct violation of Imperial vessel registration requirements. The ship has been illegally stripped of standard nav-computer safety restrictions and subjected to numerous unauthorized drive and weapons modifications. Its Class 0.5 hyperdrive has been recorded at speeds exceeding theoretical design limits. Intelligence reports link the vessel directly to known Rebel Alliance operations and high-profile criminal activity across multiple sectors. Imperial customs and enforcement units are authorized to board and detain this vessel on sight under standing Naval Security Directive 77-Aurek."
                },
                new() {
                    Id = 14, Name = "Lightsaber", Type = "Melee", Faction = "Jedi / Sith",
                    Synopsis = "Ancient energy blade of the Jedi Order and Sith, powered by a kyber crystal — prohibited under Imperial law.",
                    Description = "The lightsaber is an ancient melee weapon historically associated with the extinct Jedi Order and the Sith. Powered by a kyber crystal that focuses energy from a Diatium power cell, the weapon produces a blade of superheated plasma capable of cutting through virtually any material, deflecting blaster fire, and serving as a channeling tool for Force-sensitive individuals. All lightsabers not in the possession of authorized Imperial personnel are classified as prohibited weapons under Imperial Edict 1147-T. Any individual found in possession of one is subject to immediate detainment and transfer to the nearest Imperial Security Bureau facility. Reports of operational lightsabers must be forwarded immediately to ISB field offices."
                },
                new() {
                    Id = 15, Name = "Vibroblade", Type = "Melee", Faction = "Various",
                    Synopsis = "Melee weapon enhanced with an ultrasonic vibration generator that dramatically increases its cutting and penetrating power.",
                    Description = "The vibroblade is a melee weapon incorporating an ultrasonic vibration generator within the blade core, oscillating the cutting edge at frequencies far beyond human perception. This vibration dramatically increases the weapon's ability to penetrate materials that would resist a standard blade, including light armor plating. Vibroblades are used by Imperial Army units in close-quarters scenarios where a blaster discharge could compromise environmental integrity, such as aboard capital ships or within pressurized facilities. They are also widely used by criminal organizations, bounty hunters, and non-military operatives who prefer a silent, reliable weapon that requires no power cell resupply."
                },
                new() {
                    Id = 16, Name = "Z6 Riot Control Baton", Type = "Melee", Faction = "Imperial",
                    Synopsis = "Electrostatic baton issued to specialized Stormtroopers for crowd control and close-quarters engagement.",
                    Description = "The Z6 riot control baton is a close-quarters weapon developed specifically for crowd suppression and non-lethal engagement scenarios where blaster fire would be excessive or politically inadvisable. The weapon delivers a powerful electrostatic discharge on contact capable of incapacitating most humanoid species through localized neural disruption. Notably, the Z6 baton has been demonstrated capable of deflecting lightsaber strikes — a classified property of its conductive alloy construction that has not been publicly disclosed. The weapon is issued to specialized urban pacification Stormtrooper units, prison guard contingents, and riot suppression details attached to planetary governance offices."
                },
                new() {
                    Id = 17, Name = "Thermal Detonator", Type = "Explosive", Faction = "Various",
                    Synopsis = "Compact spherical explosive that generates an intense imploding plasma detonation — one of the most destructive personal weapons in the galaxy.",
                    Description = "The thermal detonator is a compact, spherical grenade capable of producing a contained implosion of superheated plasma within a variable blast radius of up to five meters. Unlike conventional explosives that project force outward, the thermal detonator's energy field collapses inward, vaporizing everything within its radius regardless of cover or armor. Imperial military doctrine restricts thermal detonators to elite special forces units only, due to the risk of collateral damage in dense environments. Unauthorized civilian possession carries an automatic Class III sentence under Imperial code. Their use in criminal extortion scenarios has been documented multiple times in Core system population centers, requiring strict import controls."
                },
                new() {
                    Id = 18, Name = "Proton Torpedo", Type = "Explosive", Faction = "Various",
                    Synopsis = "High-yield guided warhead carried by starfighters, designed to defeat heavy hull armor and deflector shields.",
                    Description = "The proton torpedo is a high-yield guided munition launched from the warhead launchers of starfighters, including the TIE Bomber and various Rebel craft. Its magnetic detonator and proton warhead deliver an explosive yield capable of defeating heavy hull armor and overcoming deflector shield gaps through direct impact at high approach velocity. Imperial Navy doctrine calls for proton torpedoes in precision strike scenarios against hardened surface targets, enemy capital ship drive sections, and deep-space installations where sustained turbolaser fire would be impractical. They are also the weapon most frequently cited in enemy attack profiles against Imperial capital ships, making proton torpedo intercept doctrine a priority area for Imperial starfighter training programs."
                },
            };

            return View(items);
        }
    }
}
