using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAICodeComplete
{
    public partial class TestForm1 : Form
    {
        public TestForm1()
        {
            InitializeComponent();
        }

        //private MemberAssessments Pack()
        //{
        //    MemberAssessments thing = new MemberAssessments();

        //    thing.MemberAssessmentsID = GetAsInteger(txtMemberAssessmentsID.Text);
        //    thing.MemberID = GetAsInteger(txtMemberID.Text);
        //    thing.Type = txtType.Text + "";
        //    thing.IntakeID = GetAsInteger(txtIntakeID.Text);
        //    thing.Division = txtDivision.Text + "";
        //    thing.EvalRequested = GetAsDateTime(dtpEvalRequested.Text);
        //    thing.EvalSent = GetAsDateTime(dtpEvalSent.Text);
        //    thing.EvalReceived = GetAsDateTime(dtpEvalReceived.Text);
        //    thing.EvalCompleted = GetAsDateTime(dtpEvalCompleted.Text);
        //    thing.EvalReportSent = GetAsDateTime(dtpEvalReportSent.Text);
        //    thing.ReferralReason = GetAsInteger(txtReferralReason.Text);
        //    thing.ReferralSource = GetAsInteger(txtReferralSource.Text);
        //    thing.ChildPerformance = txtChildPerformance.Text + "";
        //    thing.FamilyInformation = txtFamilyInformation.Text + "";
        //    thing.EvalHistory = txtEvalHistory.Text + "";
        //    thing.OtherEvaluations = txtOtherEvaluations.Text + "";
        //    thing.OtherServices = txtOtherServices.Text + "";
        //    thing.DailyActivities = txtDailyActivities.Text + "";
        //    thing.ChallengingActivities = txtChallengingActivities.Text + "";
        //    thing.DevelopmentConcerns = txtDevelopmentConcerns.Text + "";
        //    thing.FamilyResources = txtFamilyResources.Text + "";
        //    thing.AdditionalConcerns = txtAdditionalConcerns.Text + "";
        //    thing.PhysicalExamDate = GetAsDateTime(dtpPhysicalExamDate.Text);
        //    thing.PhysicalExamMD = txtPhysicalExamMD.Text + "";
        //    thing.MedicalHistory = txtMedicalHistory.Text + "";
        //    thing.HearingExamDate = GetAsDateTime(dtpHearingExamDate.Text);
        //    thing.HearingExamMD = txtHearingExamMD.Text + "";
        //    thing.HearingExamInstrument = txtHearingExamInstrument.Text + "";
        //    thing.HearingExamResults = txtHearingExamResults.Text + "";
        //    thing.VisionExamDate = GetAsDateTime(dtpVisionExamDate.Text);
        //    thing.VisionExamMD = txtVisionExamMD.Text + "";
        //    thing.VisionExamInstrument = txtVisionExamInstrument.Text + "";
        //    thing.VisionExamResults = txtVisionExamResults.Text + "";
        //    thing.CognitiveDevelopment = txtCognitiveDevelopment.Text + "";
        //    thing.CommunicationDevelopment = txtCommunicationDevelopment.Text + "";
        //    thing.SocialEmotionalDevelopment = txtSocialEmotionalDevelopment.Text + "";
        //    thing.PhysicalDevelopment = txtPhysicalDevelopment.Text + "";
        //    thing.AdaptiveDevelopment = txtAdaptiveDevelopment.Text + "";
        //    thing.OtherDevelopment = txtOtherDevelopment.Text + "";
        //    thing.EvaluationDate1 = GetAsDateTime(dtpEvaluationDate1.Text);
        //    thing.EvaluationAge1 = txtEvaluationAge1.Text + "";
        //    thing.EvaluationProcedures1 = txtEvaluationProcedures1.Text + "";
        //    thing.EvaluationResults1 = txtEvaluationResults1.Text + "";
        //    thing.EvaluationAdmin1 = txtEvaluationAdmin1.Text + "";
        //    thing.EvaluationDate2 = GetAsDateTime(dtpEvaluationDate2.Text);
        //    thing.EvaluationAge2 = txtEvaluationAge2.Text + "";
        //    thing.EvaluationProcedures2 = txtEvaluationProcedures2.Text + "";
        //    thing.EvaluationResults2 = txtEvaluationResults2.Text + "";
        //    thing.EvaluationAdmin2 = txtEvaluationAdmin2.Text + "";
        //    thing.EvaluationDate3 = GetAsDateTime(dtpEvaluationDate3.Text);
        //    thing.EvaluationAge3 = txtEvaluationAge3.Text + "";
        //    thing.EvaluationProcedures3 = txtEvaluationProcedures3.Text + "";
        //    thing.EvaluationResults3 = txtEvaluationResults3.Text + "";
        //    thing.EvaluationAdmin3 = txtEvaluationAdmin3.Text + "";
        //    thing.EvaluationDate4 = GetAsDateTime(dtpEvaluationDate4.Text);
        //    thing.EvaluationAge4 = txtEvaluationAge4.Text + "";
        //    thing.EvaluationProcedures4 = txtEvaluationProcedures4.Text + "";
        //    thing.EvaluationResults4 = txtEvaluationResults4.Text + "";
        //    thing.EvaluationAdmin4 = txtEvaluationAdmin4.Text + "";
        //    thing.EvaluationDate5 = GetAsDateTime(dtpEvaluationDate5.Text);
        //    thing.EvaluationAge5 = txtEvaluationAge5.Text + "";
        //    thing.EvaluationProcedures5 = txtEvaluationProcedures5.Text + "";
        //    thing.EvaluationResults5 = txtEvaluationResults5.Text + "";
        //    thing.EvaluationAdmin5 = txtEvaluationAdmin5.Text + "";
        //    thing.MemberEIEligibilityID = txtMemberEIEligibilityID.Text + "";
        //    thing.EligibilityCause = txtEligibilityCause.Text + "";
        //    thing.ActivitiesToParticipate = txtActivitiesToParticipate.Text + "";
        //    thing.SkillsToLearn = txtSkillsToLearn.Text + "";
        //    thing.SupportTools = txtSupportTools.Text + "";
        //    thing.OtherReferrals = txtOtherReferrals.Text + "";
        //    thing.OtherInformation = txtOtherInformation.Text + "";
        //    thing.CreatedBy = txtCreatedBy.Text + "";
        //    thing.CreatedDate = GetAsDateTime(dtpCreatedDate.Text);
        //    thing.CreatedFrom = txtCreatedFrom.Text + "";
        //    thing.UpdatedBy = txtUpdatedBy.Text + "";
        //    thing.UpdatedDate = GetAsDateTime(dtpUpdatedDate.Text);
        //    thing.UpdatedFrom = txtUpdatedFrom.Text + "";
        //    thing.WaiverStatus = GetAsInteger(txtWaiverStatus.Text);
        //    thing.PrimaryExceptionality = GetAsInteger(txtPrimaryExceptionality.Text);
        //    thing.OtherExceptionalities = GetAsInteger(txtOtherExceptionalities.Text);
        //    thing.EvaluationType = GetAsInteger(txtEvaluationType.Text);
        //    thing.EvaluationResults = GetAsInteger(txtEvaluationResults.Text);
        //    thing.TrackingCategories = GetAsInteger(txtTrackingCategories.Text);
        //    thing.ProcessInitiated = GetAsDateTime(dtpProcessInitiated.Text);
        //    thing.WaiverApproval = GetAsDateTime(dtpWaiverApproval.Text);
        //    thing.Reevaluation = GetAsDateTime(dtpReevaluation.Text);
        //    thing.Recertification = GetAsDateTime(dtpRecertification.Text);
        //    if (chkMAEligible.Checked)
        //    {
        //        thing.MAEligible = true;
        //    }
        //    else
        //    {
        //        thing.MAEligible = false;
        //    }

        //    thing.CardIssueNumber = txtCardIssueNumber.Text + "";
        //    thing.MCINumber = txtMCINumber.Text + "";
        //    if (chkMAWAnomeetingdate.Checked)
        //    {
        //        thing.MAWAnomeetingdate = true;
        //    }
        //    else
        //    {
        //        thing.MAWAnomeetingdate = false;
        //    }

        //    if (chkMAWArefusedtransition.Checked)
        //    {
        //        thing.MAWArefusedtransition = true;
        //    }
        //    else
        //    {
        //        thing.MAWArefusedtransition = false;
        //    }

        //    thing.MAWAletterdate = GetAsDateTime(dtpMAWAletterdate.Text);
        //    thing.MAWAmeetingdate = GetAsDateTime(dtpMAWAmeetingdate.Text);
        //    thing.MAWAdelayreason = GetAsInteger(txtMAWAdelayreason.Text);
        //    thing.TerminationDate = GetAsDateTime(dtpTerminationDate.Text);
        //    thing.ReasonForTermination = GetAsInteger(txtReasonForTermination.Text);
        //    thing.MDEDelay = GetAsInteger(txtMDEDelay.Text);
        //    thing.EIMtgDelay = GetAsInteger(txtEIMtgDelay.Text);
        //    thing.DevAge = txtDevAge.Text + "";
        //    thing.DevDelay = txtDevDelay.Text + "";
        //    thing.StandardDev = txtStandardDev.Text + "";
        //    thing.MDEExamdate = GetAsDateTime(dtpMDEExamdate.Text);

        //    return thing;
        //}

        //private void Unpack(MemberAssessments thing)
        //{
        //    txtMemberAssessmentsID.Text = thing.MemberAssessmentsID.ToString() + "";
        //    txtMemberID.Text = thing.MemberID.ToString() + "";
        //    txtType.Text = thing.Type + "";
        //    txtIntakeID.Text = thing.IntakeID.ToString() + "";
        //    txtDivision.Text = thing.Division + "";
        //    if (thing.EvalRequested != Convert.ToDateTime(null))
        //    {
        //        dtpEvalRequested.Value = thing.EvalRequested;
        //    }
        //    else
        //    {
        //        dtpEvalRequested.Value = Convert.ToDateTime(null);
        //    }

        //    if (thing.EvalSent != Convert.ToDateTime(null))
        //    {
        //        dtpEvalSent.Value = thing.EvalSent;
        //    }
        //    else
        //    {
        //        dtpEvalSent.Value = Convert.ToDateTime(null);
        //    }

        //    if (thing.EvalReceived != Convert.ToDateTime(null))
        //    {
        //        dtpEvalReceived.Value = thing.EvalReceived;
        //    }
        //    else
        //    {
        //        dtpEvalReceived.Value = Convert.ToDateTime(null);
        //    }

        //    if (thing.EvalCompleted != Convert.ToDateTime(null))
        //    {
        //        dtpEvalCompleted.Value = thing.EvalCompleted;
        //    }
        //    else
        //    {
        //        dtpEvalCompleted.Value = Convert.ToDateTime(null);
        //    }

        //    if (thing.EvalReportSent != Convert.ToDateTime(null))
        //    {
        //        dtpEvalReportSent.Value = thing.EvalReportSent;
        //    }
        //    else
        //    {
        //        dtpEvalReportSent.Value = Convert.ToDateTime(null);
        //    }

        //    txtReferralReason.Text = thing.ReferralReason.ToString() + "";
        //    txtReferralSource.Text = thing.ReferralSource.ToString() + "";
        //    txtChildPerformance.Text = thing.ChildPerformance + "";
        //    txtFamilyInformation.Text = thing.FamilyInformation + "";
        //    txtEvalHistory.Text = thing.EvalHistory + "";
        //    txtOtherEvaluations.Text = thing.OtherEvaluations + "";
        //    txtOtherServices.Text = thing.OtherServices + "";
        //    txtDailyActivities.Text = thing.DailyActivities + "";
        //    txtChallengingActivities.Text = thing.ChallengingActivities + "";
        //    txtDevelopmentConcerns.Text = thing.DevelopmentConcerns + "";
        //    txtFamilyResources.Text = thing.FamilyResources + "";
        //    txtAdditionalConcerns.Text = thing.AdditionalConcerns + "";
        //    if (thing.PhysicalExamDate != Convert.ToDateTime(null))
        //    {
        //        dtpPhysicalExamDate.Value = thing.PhysicalExamDate;
        //    }
        //    else
        //    {
        //        dtpPhysicalExamDate.Value = Convert.ToDateTime(null);
        //    }

        //    txtPhysicalExamMD.Text = thing.PhysicalExamMD + "";
        //    txtMedicalHistory.Text = thing.MedicalHistory + "";
        //    if (thing.HearingExamDate != Convert.ToDateTime(null))
        //    {
        //        dtpHearingExamDate.Value = thing.HearingExamDate;
        //    }
        //    else
        //    {
        //        dtpHearingExamDate.Value = Convert.ToDateTime(null);
        //    }

        //    txtHearingExamMD.Text = thing.HearingExamMD + "";
        //    txtHearingExamInstrument.Text = thing.HearingExamInstrument + "";
        //    txtHearingExamResults.Text = thing.HearingExamResults + "";
        //    if (thing.VisionExamDate != Convert.ToDateTime(null))
        //    {
        //        dtpVisionExamDate.Value = thing.VisionExamDate;
        //    }
        //    else
        //    {
        //        dtpVisionExamDate.Value = Convert.ToDateTime(null);
        //    }

        //    txtVisionExamMD.Text = thing.VisionExamMD + "";
        //    txtVisionExamInstrument.Text = thing.VisionExamInstrument + "";
        //    txtVisionExamResults.Text = thing.VisionExamResults + "";
        //    txtCognitiveDevelopment.Text = thing.CognitiveDevelopment + "";
        //    txtCommunicationDevelopment.Text = thing.CommunicationDevelopment + "";
        //    txtSocialEmotionalDevelopment.Text = thing.SocialEmotionalDevelopment + "";
        //    txtPhysicalDevelopment.Text = thing.PhysicalDevelopment + "";
        //    txtAdaptiveDevelopment.Text = thing.AdaptiveDevelopment + "";
        //    txtOtherDevelopment.Text = thing.OtherDevelopment + "";
        //    if (thing.EvaluationDate1 != Convert.ToDateTime(null))
        //    {
        //        dtpEvaluationDate1.Value = thing.EvaluationDate1;
        //    }
        //    else
        //    {
        //        dtpEvaluationDate1.Value = Convert.ToDateTime(null);
        //    }

        //    txtEvaluationAge1.Text = thing.EvaluationAge1 + "";
        //    txtEvaluationProcedures1.Text = thing.EvaluationProcedures1 + "";
        //    txtEvaluationResults1.Text = thing.EvaluationResults1 + "";
        //    txtEvaluationAdmin1.Text = thing.EvaluationAdmin1 + "";
        //    if (thing.EvaluationDate2 != Convert.ToDateTime(null))
        //    {
        //        dtpEvaluationDate2.Value = thing.EvaluationDate2;
        //    }
        //    else
        //    {
        //        dtpEvaluationDate2.Value = Convert.ToDateTime(null);
        //    }

        //    txtEvaluationAge2.Text = thing.EvaluationAge2 + "";
        //    txtEvaluationProcedures2.Text = thing.EvaluationProcedures2 + "";
        //    txtEvaluationResults2.Text = thing.EvaluationResults2 + "";
        //    txtEvaluationAdmin2.Text = thing.EvaluationAdmin2 + "";
        //    if (thing.EvaluationDate3 != Convert.ToDateTime(null))
        //    {
        //        dtpEvaluationDate3.Value = thing.EvaluationDate3;
        //    }
        //    else
        //    {
        //        dtpEvaluationDate3.Value = Convert.ToDateTime(null);
        //    }

        //    txtEvaluationAge3.Text = thing.EvaluationAge3 + "";
        //    txtEvaluationProcedures3.Text = thing.EvaluationProcedures3 + "";
        //    txtEvaluationResults3.Text = thing.EvaluationResults3 + "";
        //    txtEvaluationAdmin3.Text = thing.EvaluationAdmin3 + "";
        //    if (thing.EvaluationDate4 != Convert.ToDateTime(null))
        //    {
        //        dtpEvaluationDate4.Value = thing.EvaluationDate4;
        //    }
        //    else
        //    {
        //        dtpEvaluationDate4.Value = Convert.ToDateTime(null);
        //    }

        //    txtEvaluationAge4.Text = thing.EvaluationAge4 + "";
        //    txtEvaluationProcedures4.Text = thing.EvaluationProcedures4 + "";
        //    txtEvaluationResults4.Text = thing.EvaluationResults4 + "";
        //    txtEvaluationAdmin4.Text = thing.EvaluationAdmin4 + "";
        //    if (thing.EvaluationDate5 != Convert.ToDateTime(null))
        //    {
        //        dtpEvaluationDate5.Value = thing.EvaluationDate5;
        //    }
        //    else
        //    {
        //        dtpEvaluationDate5.Value = Convert.ToDateTime(null);
        //    }

        //    txtEvaluationAge5.Text = thing.EvaluationAge5 + "";
        //    txtEvaluationProcedures5.Text = thing.EvaluationProcedures5 + "";
        //    txtEvaluationResults5.Text = thing.EvaluationResults5 + "";
        //    txtEvaluationAdmin5.Text = thing.EvaluationAdmin5 + "";
        //    txtMemberEIEligibilityID.Text = thing.MemberEIEligibilityID + "";
        //    txtEligibilityCause.Text = thing.EligibilityCause + "";
        //    txtActivitiesToParticipate.Text = thing.ActivitiesToParticipate + "";
        //    txtSkillsToLearn.Text = thing.SkillsToLearn + "";
        //    txtSupportTools.Text = thing.SupportTools + "";
        //    txtOtherReferrals.Text = thing.OtherReferrals + "";
        //    txtOtherInformation.Text = thing.OtherInformation + "";
        //    txtCreatedBy.Text = thing.CreatedBy + "";
        //    if (thing.CreatedDate != Convert.ToDateTime(null))
        //    {
        //        dtpCreatedDate.Value = thing.CreatedDate;
        //    }
        //    else
        //    {
        //        dtpCreatedDate.Value = Convert.ToDateTime(null);
        //    }

        //    txtCreatedFrom.Text = thing.CreatedFrom + "";
        //    txtUpdatedBy.Text = thing.UpdatedBy + "";
        //    if (thing.UpdatedDate != Convert.ToDateTime(null))
        //    {
        //        dtpUpdatedDate.Value = thing.UpdatedDate;
        //    }
        //    else
        //    {
        //        dtpUpdatedDate.Value = Convert.ToDateTime(null);
        //    }

        //    txtUpdatedFrom.Text = thing.UpdatedFrom + "";
        //    txtWaiverStatus.Text = thing.WaiverStatus.ToString() + "";
        //    txtPrimaryExceptionality.Text = thing.PrimaryExceptionality.ToString() + "";
        //    txtOtherExceptionalities.Text = thing.OtherExceptionalities.ToString() + "";
        //    txtEvaluationType.Text = thing.EvaluationType.ToString() + "";
        //    txtEvaluationResults.Text = thing.EvaluationResults.ToString() + "";
        //    txtTrackingCategories.Text = thing.TrackingCategories.ToString() + "";
        //    if (thing.ProcessInitiated != Convert.ToDateTime(null))
        //    {
        //        dtpProcessInitiated.Value = thing.ProcessInitiated;
        //    }
        //    else
        //    {
        //        dtpProcessInitiated.Value = Convert.ToDateTime(null);
        //    }

        //    if (thing.WaiverApproval != Convert.ToDateTime(null))
        //    {
        //        dtpWaiverApproval.Value = thing.WaiverApproval;
        //    }
        //    else
        //    {
        //        dtpWaiverApproval.Value = Convert.ToDateTime(null);
        //    }

        //    if (thing.Reevaluation != Convert.ToDateTime(null))
        //    {
        //        dtpReevaluation.Value = thing.Reevaluation;
        //    }
        //    else
        //    {
        //        dtpReevaluation.Value = Convert.ToDateTime(null);
        //    }

        //    if (thing.Recertification != Convert.ToDateTime(null))
        //    {
        //        dtpRecertification.Value = thing.Recertification;
        //    }
        //    else
        //    {
        //        dtpRecertification.Value = Convert.ToDateTime(null);
        //    }

        //    if (thing.MAEligible)
        //    {
        //        chkMAEligible.Checked = true;
        //    }
        //    else
        //    {
        //        chkMAEligible.Checked = false;
        //    }

        //    txtCardIssueNumber.Text = thing.CardIssueNumber + "";
        //    txtMCINumber.Text = thing.MCINumber + "";
        //    if (thing.MAWAnomeetingdate)
        //    {
        //        chkMAWAnomeetingdate.Checked = true;
        //    }
        //    else
        //    {
        //        chkMAWAnomeetingdate.Checked = false;
        //    }

        //    if (thing.MAWArefusedtransition)
        //    {
        //        chkMAWArefusedtransition.Checked = true;
        //    }
        //    else
        //    {
        //        chkMAWArefusedtransition.Checked = false;
        //    }

        //    if (thing.MAWAletterdate != Convert.ToDateTime(null))
        //    {
        //        dtpMAWAletterdate.Value = thing.MAWAletterdate;
        //    }
        //    else
        //    {
        //        dtpMAWAletterdate.Value = Convert.ToDateTime(null);
        //    }

        //    if (thing.MAWAmeetingdate != Convert.ToDateTime(null))
        //    {
        //        dtpMAWAmeetingdate.Value = thing.MAWAmeetingdate;
        //    }
        //    else
        //    {
        //        dtpMAWAmeetingdate.Value = Convert.ToDateTime(null);
        //    }

        //    txtMAWAdelayreason.Text = thing.MAWAdelayreason.ToString() + "";
        //    if (thing.TerminationDate != Convert.ToDateTime(null))
        //    {
        //        dtpTerminationDate.Value = thing.TerminationDate;
        //    }
        //    else
        //    {
        //        dtpTerminationDate.Value = Convert.ToDateTime(null);
        //    }

        //    txtReasonForTermination.Text = thing.ReasonForTermination.ToString() + "";
        //    txtMDEDelay.Text = thing.MDEDelay.ToString() + "";
        //    txtEIMtgDelay.Text = thing.EIMtgDelay.ToString() + "";
        //    txtDevAge.Text = thing.DevAge + "";
        //    txtDevDelay.Text = thing.DevDelay + "";
        //    txtStandardDev.Text = thing.StandardDev + "";
        //    if (thing.MDEExamdate != Convert.ToDateTime(null))
        //    {
        //        dtpMDEExamdate.Value = thing.MDEExamdate;
        //    }
        //    else
        //    {
        //        dtpMDEExamdate.Value = Convert.ToDateTime(null);
        //    }
        //}

        private void btnEnableAll_Click(object sender, EventArgs e)
        {
            this.txtMemberAssessmentsID.Enabled = true;
            this.txtMemberID.Enabled = true;
            this.txtType.Enabled = true;
            this.txtIntakeID.Enabled = true;
            this.txtDivision.Enabled = true;
            this.dtpEvalRequested.Enabled = true;
            this.dtpEvalSent.Enabled = true;
            this.dtpEvalReceived.Enabled = true;
            this.dtpEvalCompleted.Enabled = true;
            this.dtpEvalReportSent.Enabled = true;
            this.txtReferralReason.Enabled = true;
            this.txtReferralSource.Enabled = true;
            this.txtChildPerformance.Enabled = true;
            this.txtFamilyInformation.Enabled = true;
            this.txtEvalHistory.Enabled = true;
            this.txtOtherEvaluations.Enabled = true;
            this.txtOtherServices.Enabled = true;
            this.txtDailyActivities.Enabled = true;
            this.txtChallengingActivities.Enabled = true;
            this.txtDevelopmentConcerns.Enabled = true;
            this.txtFamilyResources.Enabled = true;
            this.txtAdditionalConcerns.Enabled = true;
            this.dtpPhysicalExamDate.Enabled = true;
            this.txtPhysicalExamMD.Enabled = true;
            this.txtMedicalHistory.Enabled = true;
            this.dtpHearingExamDate.Enabled = true;
            this.txtHearingExamMD.Enabled = true;
            this.txtHearingExamInstrument.Enabled = true;
            this.txtHearingExamResults.Enabled = true;
            this.dtpVisionExamDate.Enabled = true;
            this.txtVisionExamMD.Enabled = true;
            this.txtVisionExamInstrument.Enabled = true;
            this.txtVisionExamResults.Enabled = true;
            this.txtCognitiveDevelopment.Enabled = true;
            this.txtCommunicationDevelopment.Enabled = true;
            this.txtSocialEmotionalDevelopment.Enabled = true;
            this.txtPhysicalDevelopment.Enabled = true;
            this.txtAdaptiveDevelopment.Enabled = true;
            this.txtOtherDevelopment.Enabled = true;
            this.dtpEvaluationDate1.Enabled = true;
            this.txtEvaluationAge1.Enabled = true;
            this.txtEvaluationProcedures1.Enabled = true;
            this.txtEvaluationResults1.Enabled = true;
            this.txtEvaluationAdmin1.Enabled = true;
            this.dtpEvaluationDate2.Enabled = true;
            this.txtEvaluationAge2.Enabled = true;
            this.txtEvaluationProcedures2.Enabled = true;
            this.txtEvaluationResults2.Enabled = true;
            this.txtEvaluationAdmin2.Enabled = true;
            this.dtpEvaluationDate3.Enabled = true;
            this.txtEvaluationAge3.Enabled = true;
            this.txtEvaluationProcedures3.Enabled = true;
            this.txtEvaluationResults3.Enabled = true;
            this.txtEvaluationAdmin3.Enabled = true;
            this.dtpEvaluationDate4.Enabled = true;
            this.txtEvaluationAge4.Enabled = true;
            this.txtEvaluationProcedures4.Enabled = true;
            this.txtEvaluationResults4.Enabled = true;
            this.txtEvaluationAdmin4.Enabled = true;
            this.dtpEvaluationDate5.Enabled = true;
            this.txtEvaluationAge5.Enabled = true;
            this.txtEvaluationProcedures5.Enabled = true;
            this.txtEvaluationResults5.Enabled = true;
            this.txtEvaluationAdmin5.Enabled = true;
            this.txtMemberEIEligibilityID.Enabled = true;
            this.txtEligibilityCause.Enabled = true;
            this.txtActivitiesToParticipate.Enabled = true;
            this.txtSkillsToLearn.Enabled = true;
            this.txtSupportTools.Enabled = true;
            this.txtOtherReferrals.Enabled = true;
            this.txtOtherInformation.Enabled = true;
            this.txtCreatedBy.Enabled = true;
            this.dtpCreatedDate.Enabled = true;
            this.txtCreatedFrom.Enabled = true;
            this.txtUpdatedBy.Enabled = true;
            this.dtpUpdatedDate.Enabled = true;
            this.txtUpdatedFrom.Enabled = true;
            this.txtWaiverStatus.Enabled = true;
            this.txtPrimaryExceptionality.Enabled = true;
            this.txtOtherExceptionalities.Enabled = true;
            this.txtEvaluationType.Enabled = true;
            this.txtEvaluationResults.Enabled = true;
            this.txtTrackingCategories.Enabled = true;
            this.dtpProcessInitiated.Enabled = true;
            this.dtpWaiverApproval.Enabled = true;
            this.dtpReevaluation.Enabled = true;
            this.dtpRecertification.Enabled = true;
            this.chkMAEligible.Enabled = true;
            this.txtCardIssueNumber.Enabled = true;
            this.txtMCINumber.Enabled = true;
            this.chkMAWAnomeetingdate.Enabled = true;
            this.chkMAWArefusedtransition.Enabled = true;
            this.dtpMAWAletterdate.Enabled = true;
            this.dtpMAWAmeetingdate.Enabled = true;
            this.txtMAWAdelayreason.Enabled = true;
            this.dtpTerminationDate.Enabled = true;
            this.txtReasonForTermination.Enabled = true;
            this.txtMDEDelay.Enabled = true;
            this.txtEIMtgDelay.Enabled = true;
            this.txtDevAge.Enabled = true;
            this.txtDevDelay.Enabled = true;
            this.txtStandardDev.Enabled = true;
            this.dtpMDEExamdate.Enabled = true;
        }

        private void btnDisableAll_Click(object sender, EventArgs e)
        {
            this.txtMemberAssessmentsID.Enabled = false;
            this.txtMemberID.Enabled = false;
            this.txtType.Enabled = false;
            this.txtIntakeID.Enabled = false;
            this.txtDivision.Enabled = false;
            this.dtpEvalRequested.Enabled = false;
            this.dtpEvalSent.Enabled = false;
            this.dtpEvalReceived.Enabled = false;
            this.dtpEvalCompleted.Enabled = false;
            this.dtpEvalReportSent.Enabled = false;
            this.txtReferralReason.Enabled = false;
            this.txtReferralSource.Enabled = false;
            this.txtChildPerformance.Enabled = false;
            this.txtFamilyInformation.Enabled = false;
            this.txtEvalHistory.Enabled = false;
            this.txtOtherEvaluations.Enabled = false;
            this.txtOtherServices.Enabled = false;
            this.txtDailyActivities.Enabled = false;
            this.txtChallengingActivities.Enabled = false;
            this.txtDevelopmentConcerns.Enabled = false;
            this.txtFamilyResources.Enabled = false;
            this.txtAdditionalConcerns.Enabled = false;
            this.dtpPhysicalExamDate.Enabled = false;
            this.txtPhysicalExamMD.Enabled = false;
            this.txtMedicalHistory.Enabled = false;
            this.dtpHearingExamDate.Enabled = false;
            this.txtHearingExamMD.Enabled = false;
            this.txtHearingExamInstrument.Enabled = false;
            this.txtHearingExamResults.Enabled = false;
            this.dtpVisionExamDate.Enabled = false;
            this.txtVisionExamMD.Enabled = false;
            this.txtVisionExamInstrument.Enabled = false;
            this.txtVisionExamResults.Enabled = false;
            this.txtCognitiveDevelopment.Enabled = false;
            this.txtCommunicationDevelopment.Enabled = false;
            this.txtSocialEmotionalDevelopment.Enabled = false;
            this.txtPhysicalDevelopment.Enabled = false;
            this.txtAdaptiveDevelopment.Enabled = false;
            this.txtOtherDevelopment.Enabled = false;
            this.dtpEvaluationDate1.Enabled = false;
            this.txtEvaluationAge1.Enabled = false;
            this.txtEvaluationProcedures1.Enabled = false;
            this.txtEvaluationResults1.Enabled = false;
            this.txtEvaluationAdmin1.Enabled = false;
            this.dtpEvaluationDate2.Enabled = false;
            this.txtEvaluationAge2.Enabled = false;
            this.txtEvaluationProcedures2.Enabled = false;
            this.txtEvaluationResults2.Enabled = false;
            this.txtEvaluationAdmin2.Enabled = false;
            this.dtpEvaluationDate3.Enabled = false;
            this.txtEvaluationAge3.Enabled = false;
            this.txtEvaluationProcedures3.Enabled = false;
            this.txtEvaluationResults3.Enabled = false;
            this.txtEvaluationAdmin3.Enabled = false;
            this.dtpEvaluationDate4.Enabled = false;
            this.txtEvaluationAge4.Enabled = false;
            this.txtEvaluationProcedures4.Enabled = false;
            this.txtEvaluationResults4.Enabled = false;
            this.txtEvaluationAdmin4.Enabled = false;
            this.dtpEvaluationDate5.Enabled = false;
            this.txtEvaluationAge5.Enabled = false;
            this.txtEvaluationProcedures5.Enabled = false;
            this.txtEvaluationResults5.Enabled = false;
            this.txtEvaluationAdmin5.Enabled = false;
            this.txtMemberEIEligibilityID.Enabled = false;
            this.txtEligibilityCause.Enabled = false;
            this.txtActivitiesToParticipate.Enabled = false;
            this.txtSkillsToLearn.Enabled = false;
            this.txtSupportTools.Enabled = false;
            this.txtOtherReferrals.Enabled = false;
            this.txtOtherInformation.Enabled = false;
            this.txtCreatedBy.Enabled = false;
            this.dtpCreatedDate.Enabled = false;
            this.txtCreatedFrom.Enabled = false;
            this.txtUpdatedBy.Enabled = false;
            this.dtpUpdatedDate.Enabled = false;
            this.txtUpdatedFrom.Enabled = false;
            this.txtWaiverStatus.Enabled = false;
            this.txtPrimaryExceptionality.Enabled = false;
            this.txtOtherExceptionalities.Enabled = false;
            this.txtEvaluationType.Enabled = false;
            this.txtEvaluationResults.Enabled = false;
            this.txtTrackingCategories.Enabled = false;
            this.dtpProcessInitiated.Enabled = false;
            this.dtpWaiverApproval.Enabled = false;
            this.dtpReevaluation.Enabled = false;
            this.dtpRecertification.Enabled = false;
            this.chkMAEligible.Enabled = false;
            this.txtCardIssueNumber.Enabled = false;
            this.txtMCINumber.Enabled = false;
            this.chkMAWAnomeetingdate.Enabled = false;
            this.chkMAWArefusedtransition.Enabled = false;
            this.dtpMAWAletterdate.Enabled = false;
            this.dtpMAWAmeetingdate.Enabled = false;
            this.txtMAWAdelayreason.Enabled = false;
            this.dtpTerminationDate.Enabled = false;
            this.txtReasonForTermination.Enabled = false;
            this.txtMDEDelay.Enabled = false;
            this.txtEIMtgDelay.Enabled = false;
            this.txtDevAge.Enabled = false;
            this.txtDevDelay.Enabled = false;
            this.txtStandardDev.Enabled = false;
            this.dtpMDEExamdate.Enabled = false;
        }

        private void btnHideAll_Click(object sender, EventArgs e)
        {
            this.txtMemberAssessmentsID.Visible = false;
            this.lblMemberAssessmentsID.Visible = false;
            this.txtMemberID.Visible = false;
            this.lblMemberID.Visible = false;
            this.txtType.Visible = false;
            this.lblType.Visible = false;
            this.txtIntakeID.Visible = false;
            this.lblIntakeID.Visible = false;
            this.txtDivision.Visible = false;
            this.lblDivision.Visible = false;
            this.dtpEvalRequested.Visible = false;
            this.lblEvalRequested.Visible = false;
            this.dtpEvalSent.Visible = false;
            this.lblEvalSent.Visible = false;
            this.dtpEvalReceived.Visible = false;
            this.lblEvalReceived.Visible = false;
            this.dtpEvalCompleted.Visible = false;
            this.lblEvalCompleted.Visible = false;
            this.dtpEvalReportSent.Visible = false;
            this.lblEvalReportSent.Visible = false;
            this.txtReferralReason.Visible = false;
            this.lblReferralReason.Visible = false;
            this.txtReferralSource.Visible = false;
            this.lblReferralSource.Visible = false;
            this.txtChildPerformance.Visible = false;
            this.lblChildPerformance.Visible = false;
            this.txtFamilyInformation.Visible = false;
            this.lblFamilyInformation.Visible = false;
            this.txtEvalHistory.Visible = false;
            this.lblEvalHistory.Visible = false;
            this.txtOtherEvaluations.Visible = false;
            this.lblOtherEvaluations.Visible = false;
            this.txtOtherServices.Visible = false;
            this.lblOtherServices.Visible = false;
            this.txtDailyActivities.Visible = false;
            this.lblDailyActivities.Visible = false;
            this.txtChallengingActivities.Visible = false;
            this.lblChallengingActivities.Visible = false;
            this.txtDevelopmentConcerns.Visible = false;
            this.lblDevelopmentConcerns.Visible = false;
            this.txtFamilyResources.Visible = false;
            this.lblFamilyResources.Visible = false;
            this.txtAdditionalConcerns.Visible = false;
            this.lblAdditionalConcerns.Visible = false;
            this.dtpPhysicalExamDate.Visible = false;
            this.lblPhysicalExamDate.Visible = false;
            this.txtPhysicalExamMD.Visible = false;
            this.lblPhysicalExamMD.Visible = false;
            this.txtMedicalHistory.Visible = false;
            this.lblMedicalHistory.Visible = false;
            this.dtpHearingExamDate.Visible = false;
            this.lblHearingExamDate.Visible = false;
            this.txtHearingExamMD.Visible = false;
            this.lblHearingExamMD.Visible = false;
            this.txtHearingExamInstrument.Visible = false;
            this.lblHearingExamInstrument.Visible = false;
            this.txtHearingExamResults.Visible = false;
            this.lblHearingExamResults.Visible = false;
            this.dtpVisionExamDate.Visible = false;
            this.lblVisionExamDate.Visible = false;
            this.txtVisionExamMD.Visible = false;
            this.lblVisionExamMD.Visible = false;
            this.txtVisionExamInstrument.Visible = false;
            this.lblVisionExamInstrument.Visible = false;
            this.txtVisionExamResults.Visible = false;
            this.lblVisionExamResults.Visible = false;
            this.txtCognitiveDevelopment.Visible = false;
            this.lblCognitiveDevelopment.Visible = false;
            this.txtCommunicationDevelopment.Visible = false;
            this.lblCommunicationDevelopment.Visible = false;
            this.txtSocialEmotionalDevelopment.Visible = false;
            this.lblSocialEmotionalDevelopment.Visible = false;
            this.txtPhysicalDevelopment.Visible = false;
            this.lblPhysicalDevelopment.Visible = false;
            this.txtAdaptiveDevelopment.Visible = false;
            this.lblAdaptiveDevelopment.Visible = false;
            this.txtOtherDevelopment.Visible = false;
            this.lblOtherDevelopment.Visible = false;
            this.dtpEvaluationDate1.Visible = false;
            this.lblEvaluationDate1.Visible = false;
            this.txtEvaluationAge1.Visible = false;
            this.lblEvaluationAge1.Visible = false;
            this.txtEvaluationProcedures1.Visible = false;
            this.lblEvaluationProcedures1.Visible = false;
            this.txtEvaluationResults1.Visible = false;
            this.lblEvaluationResults1.Visible = false;
            this.txtEvaluationAdmin1.Visible = false;
            this.lblEvaluationAdmin1.Visible = false;
            this.dtpEvaluationDate2.Visible = false;
            this.lblEvaluationDate2.Visible = false;
            this.txtEvaluationAge2.Visible = false;
            this.lblEvaluationAge2.Visible = false;
            this.txtEvaluationProcedures2.Visible = false;
            this.lblEvaluationProcedures2.Visible = false;
            this.txtEvaluationResults2.Visible = false;
            this.lblEvaluationResults2.Visible = false;
            this.txtEvaluationAdmin2.Visible = false;
            this.lblEvaluationAdmin2.Visible = false;
            this.dtpEvaluationDate3.Visible = false;
            this.lblEvaluationDate3.Visible = false;
            this.txtEvaluationAge3.Visible = false;
            this.lblEvaluationAge3.Visible = false;
            this.txtEvaluationProcedures3.Visible = false;
            this.lblEvaluationProcedures3.Visible = false;
            this.txtEvaluationResults3.Visible = false;
            this.lblEvaluationResults3.Visible = false;
            this.txtEvaluationAdmin3.Visible = false;
            this.lblEvaluationAdmin3.Visible = false;
            this.dtpEvaluationDate4.Visible = false;
            this.lblEvaluationDate4.Visible = false;
            this.txtEvaluationAge4.Visible = false;
            this.lblEvaluationAge4.Visible = false;
            this.txtEvaluationProcedures4.Visible = false;
            this.lblEvaluationProcedures4.Visible = false;
            this.txtEvaluationResults4.Visible = false;
            this.lblEvaluationResults4.Visible = false;
            this.txtEvaluationAdmin4.Visible = false;
            this.lblEvaluationAdmin4.Visible = false;
            this.dtpEvaluationDate5.Visible = false;
            this.lblEvaluationDate5.Visible = false;
            this.txtEvaluationAge5.Visible = false;
            this.lblEvaluationAge5.Visible = false;
            this.txtEvaluationProcedures5.Visible = false;
            this.lblEvaluationProcedures5.Visible = false;
            this.txtEvaluationResults5.Visible = false;
            this.lblEvaluationResults5.Visible = false;
            this.txtEvaluationAdmin5.Visible = false;
            this.lblEvaluationAdmin5.Visible = false;
            this.txtMemberEIEligibilityID.Visible = false;
            this.lblMemberEIEligibilityID.Visible = false;
            this.txtEligibilityCause.Visible = false;
            this.lblEligibilityCause.Visible = false;
            this.txtActivitiesToParticipate.Visible = false;
            this.lblActivitiesToParticipate.Visible = false;
            this.txtSkillsToLearn.Visible = false;
            this.lblSkillsToLearn.Visible = false;
            this.txtSupportTools.Visible = false;
            this.lblSupportTools.Visible = false;
            this.txtOtherReferrals.Visible = false;
            this.lblOtherReferrals.Visible = false;
            this.txtOtherInformation.Visible = false;
            this.lblOtherInformation.Visible = false;
            this.txtCreatedBy.Visible = false;
            this.lblCreatedBy.Visible = false;
            this.dtpCreatedDate.Visible = false;
            this.lblCreatedDate.Visible = false;
            this.txtCreatedFrom.Visible = false;
            this.lblCreatedFrom.Visible = false;
            this.txtUpdatedBy.Visible = false;
            this.lblUpdatedBy.Visible = false;
            this.dtpUpdatedDate.Visible = false;
            this.lblUpdatedDate.Visible = false;
            this.txtUpdatedFrom.Visible = false;
            this.lblUpdatedFrom.Visible = false;
            this.txtWaiverStatus.Visible = false;
            this.lblWaiverStatus.Visible = false;
            this.txtPrimaryExceptionality.Visible = false;
            this.lblPrimaryExceptionality.Visible = false;
            this.txtOtherExceptionalities.Visible = false;
            this.lblOtherExceptionalities.Visible = false;
            this.txtEvaluationType.Visible = false;
            this.lblEvaluationType.Visible = false;
            this.txtEvaluationResults.Visible = false;
            this.lblEvaluationResults.Visible = false;
            this.txtTrackingCategories.Visible = false;
            this.lblTrackingCategories.Visible = false;
            this.dtpProcessInitiated.Visible = false;
            this.lblProcessInitiated.Visible = false;
            this.dtpWaiverApproval.Visible = false;
            this.lblWaiverApproval.Visible = false;
            this.dtpReevaluation.Visible = false;
            this.lblReevaluation.Visible = false;
            this.dtpRecertification.Visible = false;
            this.lblRecertification.Visible = false;
            this.chkMAEligible.Visible = false;
            this.lblMAEligible.Visible = false;
            this.txtCardIssueNumber.Visible = false;
            this.lblCardIssueNumber.Visible = false;
            this.txtMCINumber.Visible = false;
            this.lblMCINumber.Visible = false;
            this.chkMAWAnomeetingdate.Visible = false;
            this.lblMAWAnomeetingdate.Visible = false;
            this.chkMAWArefusedtransition.Visible = false;
            this.lblMAWArefusedtransition.Visible = false;
            this.dtpMAWAletterdate.Visible = false;
            this.lblMAWAletterdate.Visible = false;
            this.dtpMAWAmeetingdate.Visible = false;
            this.lblMAWAmeetingdate.Visible = false;
            this.txtMAWAdelayreason.Visible = false;
            this.lblMAWAdelayreason.Visible = false;
            this.dtpTerminationDate.Visible = false;
            this.lblTerminationDate.Visible = false;
            this.txtReasonForTermination.Visible = false;
            this.lblReasonForTermination.Visible = false;
            this.txtMDEDelay.Visible = false;
            this.lblMDEDelay.Visible = false;
            this.txtEIMtgDelay.Visible = false;
            this.lblEIMtgDelay.Visible = false;
            this.txtDevAge.Visible = false;
            this.lblDevAge.Visible = false;
            this.txtDevDelay.Visible = false;
            this.lblDevDelay.Visible = false;
            this.txtStandardDev.Visible = false;
            this.lblStandardDev.Visible = false;
            this.dtpMDEExamdate.Visible = false;
            this.lblMDEExamdate.Visible = false;
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            this.txtMemberAssessmentsID.Visible = true;
            this.lblMemberAssessmentsID.Visible = true;
            this.txtMemberID.Visible = true;
            this.lblMemberID.Visible = true;
            this.txtType.Visible = true;
            this.lblType.Visible = true;
            this.txtIntakeID.Visible = true;
            this.lblIntakeID.Visible = true;
            this.txtDivision.Visible = true;
            this.lblDivision.Visible = true;
            this.dtpEvalRequested.Visible = true;
            this.lblEvalRequested.Visible = true;
            this.dtpEvalSent.Visible = true;
            this.lblEvalSent.Visible = true;
            this.dtpEvalReceived.Visible = true;
            this.lblEvalReceived.Visible = true;
            this.dtpEvalCompleted.Visible = true;
            this.lblEvalCompleted.Visible = true;
            this.dtpEvalReportSent.Visible = true;
            this.lblEvalReportSent.Visible = true;
            this.txtReferralReason.Visible = true;
            this.lblReferralReason.Visible = true;
            this.txtReferralSource.Visible = true;
            this.lblReferralSource.Visible = true;
            this.txtChildPerformance.Visible = true;
            this.lblChildPerformance.Visible = true;
            this.txtFamilyInformation.Visible = true;
            this.lblFamilyInformation.Visible = true;
            this.txtEvalHistory.Visible = true;
            this.lblEvalHistory.Visible = true;
            this.txtOtherEvaluations.Visible = true;
            this.lblOtherEvaluations.Visible = true;
            this.txtOtherServices.Visible = true;
            this.lblOtherServices.Visible = true;
            this.txtDailyActivities.Visible = true;
            this.lblDailyActivities.Visible = true;
            this.txtChallengingActivities.Visible = true;
            this.lblChallengingActivities.Visible = true;
            this.txtDevelopmentConcerns.Visible = true;
            this.lblDevelopmentConcerns.Visible = true;
            this.txtFamilyResources.Visible = true;
            this.lblFamilyResources.Visible = true;
            this.txtAdditionalConcerns.Visible = true;
            this.lblAdditionalConcerns.Visible = true;
            this.dtpPhysicalExamDate.Visible = true;
            this.lblPhysicalExamDate.Visible = true;
            this.txtPhysicalExamMD.Visible = true;
            this.lblPhysicalExamMD.Visible = true;
            this.txtMedicalHistory.Visible = true;
            this.lblMedicalHistory.Visible = true;
            this.dtpHearingExamDate.Visible = true;
            this.lblHearingExamDate.Visible = true;
            this.txtHearingExamMD.Visible = true;
            this.lblHearingExamMD.Visible = true;
            this.txtHearingExamInstrument.Visible = true;
            this.lblHearingExamInstrument.Visible = true;
            this.txtHearingExamResults.Visible = true;
            this.lblHearingExamResults.Visible = true;
            this.dtpVisionExamDate.Visible = true;
            this.lblVisionExamDate.Visible = true;
            this.txtVisionExamMD.Visible = true;
            this.lblVisionExamMD.Visible = true;
            this.txtVisionExamInstrument.Visible = true;
            this.lblVisionExamInstrument.Visible = true;
            this.txtVisionExamResults.Visible = true;
            this.lblVisionExamResults.Visible = true;
            this.txtCognitiveDevelopment.Visible = true;
            this.lblCognitiveDevelopment.Visible = true;
            this.txtCommunicationDevelopment.Visible = true;
            this.lblCommunicationDevelopment.Visible = true;
            this.txtSocialEmotionalDevelopment.Visible = true;
            this.lblSocialEmotionalDevelopment.Visible = true;
            this.txtPhysicalDevelopment.Visible = true;
            this.lblPhysicalDevelopment.Visible = true;
            this.txtAdaptiveDevelopment.Visible = true;
            this.lblAdaptiveDevelopment.Visible = true;
            this.txtOtherDevelopment.Visible = true;
            this.lblOtherDevelopment.Visible = true;
            this.dtpEvaluationDate1.Visible = true;
            this.lblEvaluationDate1.Visible = true;
            this.txtEvaluationAge1.Visible = true;
            this.lblEvaluationAge1.Visible = true;
            this.txtEvaluationProcedures1.Visible = true;
            this.lblEvaluationProcedures1.Visible = true;
            this.txtEvaluationResults1.Visible = true;
            this.lblEvaluationResults1.Visible = true;
            this.txtEvaluationAdmin1.Visible = true;
            this.lblEvaluationAdmin1.Visible = true;
            this.dtpEvaluationDate2.Visible = true;
            this.lblEvaluationDate2.Visible = true;
            this.txtEvaluationAge2.Visible = true;
            this.lblEvaluationAge2.Visible = true;
            this.txtEvaluationProcedures2.Visible = true;
            this.lblEvaluationProcedures2.Visible = true;
            this.txtEvaluationResults2.Visible = true;
            this.lblEvaluationResults2.Visible = true;
            this.txtEvaluationAdmin2.Visible = true;
            this.lblEvaluationAdmin2.Visible = true;
            this.dtpEvaluationDate3.Visible = true;
            this.lblEvaluationDate3.Visible = true;
            this.txtEvaluationAge3.Visible = true;
            this.lblEvaluationAge3.Visible = true;
            this.txtEvaluationProcedures3.Visible = true;
            this.lblEvaluationProcedures3.Visible = true;
            this.txtEvaluationResults3.Visible = true;
            this.lblEvaluationResults3.Visible = true;
            this.txtEvaluationAdmin3.Visible = true;
            this.lblEvaluationAdmin3.Visible = true;
            this.dtpEvaluationDate4.Visible = true;
            this.lblEvaluationDate4.Visible = true;
            this.txtEvaluationAge4.Visible = true;
            this.lblEvaluationAge4.Visible = true;
            this.txtEvaluationProcedures4.Visible = true;
            this.lblEvaluationProcedures4.Visible = true;
            this.txtEvaluationResults4.Visible = true;
            this.lblEvaluationResults4.Visible = true;
            this.txtEvaluationAdmin4.Visible = true;
            this.lblEvaluationAdmin4.Visible = true;
            this.dtpEvaluationDate5.Visible = true;
            this.lblEvaluationDate5.Visible = true;
            this.txtEvaluationAge5.Visible = true;
            this.lblEvaluationAge5.Visible = true;
            this.txtEvaluationProcedures5.Visible = true;
            this.lblEvaluationProcedures5.Visible = true;
            this.txtEvaluationResults5.Visible = true;
            this.lblEvaluationResults5.Visible = true;
            this.txtEvaluationAdmin5.Visible = true;
            this.lblEvaluationAdmin5.Visible = true;
            this.txtMemberEIEligibilityID.Visible = true;
            this.lblMemberEIEligibilityID.Visible = true;
            this.txtEligibilityCause.Visible = true;
            this.lblEligibilityCause.Visible = true;
            this.txtActivitiesToParticipate.Visible = true;
            this.lblActivitiesToParticipate.Visible = true;
            this.txtSkillsToLearn.Visible = true;
            this.lblSkillsToLearn.Visible = true;
            this.txtSupportTools.Visible = true;
            this.lblSupportTools.Visible = true;
            this.txtOtherReferrals.Visible = true;
            this.lblOtherReferrals.Visible = true;
            this.txtOtherInformation.Visible = true;
            this.lblOtherInformation.Visible = true;
            this.txtCreatedBy.Visible = true;
            this.lblCreatedBy.Visible = true;
            this.dtpCreatedDate.Visible = true;
            this.lblCreatedDate.Visible = true;
            this.txtCreatedFrom.Visible = true;
            this.lblCreatedFrom.Visible = true;
            this.txtUpdatedBy.Visible = true;
            this.lblUpdatedBy.Visible = true;
            this.dtpUpdatedDate.Visible = true;
            this.lblUpdatedDate.Visible = true;
            this.txtUpdatedFrom.Visible = true;
            this.lblUpdatedFrom.Visible = true;
            this.txtWaiverStatus.Visible = true;
            this.lblWaiverStatus.Visible = true;
            this.txtPrimaryExceptionality.Visible = true;
            this.lblPrimaryExceptionality.Visible = true;
            this.txtOtherExceptionalities.Visible = true;
            this.lblOtherExceptionalities.Visible = true;
            this.txtEvaluationType.Visible = true;
            this.lblEvaluationType.Visible = true;
            this.txtEvaluationResults.Visible = true;
            this.lblEvaluationResults.Visible = true;
            this.txtTrackingCategories.Visible = true;
            this.lblTrackingCategories.Visible = true;
            this.dtpProcessInitiated.Visible = true;
            this.lblProcessInitiated.Visible = true;
            this.dtpWaiverApproval.Visible = true;
            this.lblWaiverApproval.Visible = true;
            this.dtpReevaluation.Visible = true;
            this.lblReevaluation.Visible = true;
            this.dtpRecertification.Visible = true;
            this.lblRecertification.Visible = true;
            this.chkMAEligible.Visible = true;
            this.lblMAEligible.Visible = true;
            this.txtCardIssueNumber.Visible = true;
            this.lblCardIssueNumber.Visible = true;
            this.txtMCINumber.Visible = true;
            this.lblMCINumber.Visible = true;
            this.chkMAWAnomeetingdate.Visible = true;
            this.lblMAWAnomeetingdate.Visible = true;
            this.chkMAWArefusedtransition.Visible = true;
            this.lblMAWArefusedtransition.Visible = true;
            this.dtpMAWAletterdate.Visible = true;
            this.lblMAWAletterdate.Visible = true;
            this.dtpMAWAmeetingdate.Visible = true;
            this.lblMAWAmeetingdate.Visible = true;
            this.txtMAWAdelayreason.Visible = true;
            this.lblMAWAdelayreason.Visible = true;
            this.dtpTerminationDate.Visible = true;
            this.lblTerminationDate.Visible = true;
            this.txtReasonForTermination.Visible = true;
            this.lblReasonForTermination.Visible = true;
            this.txtMDEDelay.Visible = true;
            this.lblMDEDelay.Visible = true;
            this.txtEIMtgDelay.Visible = true;
            this.lblEIMtgDelay.Visible = true;
            this.txtDevAge.Visible = true;
            this.lblDevAge.Visible = true;
            this.txtDevDelay.Visible = true;
            this.lblDevDelay.Visible = true;
            this.txtStandardDev.Visible = true;
            this.lblStandardDev.Visible = true;
            this.dtpMDEExamdate.Visible = true;
            this.lblMDEExamdate.Visible = true;
        }

        private int GetAsInteger(string input)
        {
            int result = 0;
            bool diditwork = int.TryParse(input, out result);
            return result;
        }

        private long GetAsLong(string input)
        {
            long result = 0;
            bool diditwork = long.TryParse(input, out result);
            return result;
        }

        private double GetAsDouble(string input)
        {
            double result = 0;
            bool diditwork = double.TryParse(input, out result);
            return result;
        }

        private DateTime GetAsDateTime(string input)
        {
            DateTime result = Convert.ToDateTime(null);
            bool diditwork = DateTime.TryParse(input, out result);
            return result;
        }

    }
}