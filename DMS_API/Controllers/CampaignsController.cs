using DMS_API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace DMS_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CampaignsController : ControllerBase
    {

        private readonly ILogger<CampaignsController> _logger;
        public CampaignsController(ILogger<CampaignsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Campaign> GetCampaigns()
        {
            return Enumerable.Range(1, 5).Select(index => new Campaign
            {
                id = Random.Shared.Next(1, 99),
                name = "Children Cancer Help",
                cause_id = Random.Shared.Next(1, 5),
                cause_name = "Children Cancer Help Fund",
                sub_title = "Supporting young cancer patients",
                img = "",
                raised = 9000,
                goal = 10000,
                description = "Dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit asuraut. This comprehensive program provides medical support, emotional care, and financial assistance to children battling cancer.",
                donors_count = 10
            })
            .ToArray();                      
        }



        [HttpGet("{id}")]
        public ActionResult<Campaign> GetCampaign(int id)
        {

            var campaign = new Campaign();
            campaign.id = Random.Shared.Next(1, 99);
            campaign.name = "Children Cancer Help";
            campaign.cause_id = Random.Shared.Next(1, 5);
            campaign.cause_name = "Children Cancer Help Fund";
            campaign.sub_title = "Supporting young cancer patients";
            campaign.img = "";
            campaign.raised = 9000;
            campaign.goal = 10000;
            campaign.description = "Dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit asuraut. This comprehensive program provides medical support, emotional care, and financial assistance to children battling cancer.";
            campaign.donors_count = 10;

            if (campaign == null)
            {
                return NotFound();
            }

            return Ok(campaign);
        }

        [HttpGet("ByCauseID/{id}")]
        public IEnumerable<Campaign> GetCampaignsByCauseID(int causeID)
        {
            return Enumerable.Range(1, 5).Select(index => new Campaign
            {
                id = Random.Shared.Next(1, 99),
                name = string.Format("GetCampaigns GetCampaigns GetCampaigns ByCauseID - {0}",causeID),
                cause_id = Random.Shared.Next(1, 5),
                cause_name = string.Format("Children Cancer Help Fund - {0}", causeID),                
                sub_title = string.Format("Children Cancer Help Fund Supporting young cancer patients {0}", causeID),      
                img = "",
                raised = 9000,
                goal = 10000,
                description = "Dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit asuraut. This comprehensive program provides medical support, emotional care, and financial assistance to children battling cancer.",
                donors_count = 10
            })
            .ToArray();
        }
    }
}
