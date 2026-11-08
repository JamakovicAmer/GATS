# Research: similar ATS products and job boards

Research for the GATS project (issue #39): how existing applicant tracking systems and job boards solve
the same problems, and which ideas GATS takes from them.

Captured on 2026-11-07 from public pages only (no login, no forms submitted, non-essential cookies declined
where the site offered it). Screenshots are PNG, 1568x702 or 1254x562. Some pages were scaled down with CSS
zoom so more content fits in one shot.

## Workable

- `01-workable-pricing.png` (https://www.workable.com/pricing)
  Three tiers (Standard / Premier / Enterprise), monthly vs. yearly price, price depends on company size.
  All tiers have unlimited active jobs; tiers differ by features (add-ons). Prices only in USD.
- `02-workable-career-page-job-list.png` (https://apply.workable.com/huggingface/)
  Hosted career page: mission statement at the top, then job list with search and filters
  (workplace type, location, department, work type). Good model for the GATS public company page.
- `03-workable-job-detail.png` (https://apply.workable.com/huggingface/j/DB4D7C0EC8/)
  Job detail with Overview / Application tabs, work mode, department and employment type under the title,
  "Share this job" link.
- `04-workable-apply-form-top.png` (.../apply/)
  Apply form without an account: name, email, summary, resume upload (drag and drop), links.
  "Autofill application" imports data from a resume.
- `05-workable-apply-form-questions.png` (.../apply/)
  Company-defined screening questions (yes/no, select, free text), notice period, data protection note
  above the footer.
- `06-workable-pipeline-stages-candidate.png` (https://www.workable.com/features)
  Product screenshot: job with stage tabs and counts (Sourced, Applied, Shortlisted, Phone screen,
  Assessment, Interview, Offer), candidate list on the left, candidate profile with tags, rating and
  tabs (Profile, Communication, Review, Collaborate, Offer, Files, Timeline).

## Teamtailor

- `07-teamtailor-pricing-quote.png` (https://www.teamtailor.com/en/pricing)
  No public prices: quote form only. Selling point is "unlimited job postings and unlimited users".
- `08-teamtailor-career-site-gallery.png` (https://career.teamtailor.com/)
  Career site with a "life at the company" photo gallery (story-style cards). Matches the GATS
  company gallery idea.
- `09-teamtailor-career-site-jobs.png` (https://career.teamtailor.com/)
  Open jobs as cards with a cover image, department, city and work mode (hybrid icon).
- `10-teamtailor-job-detail.png` (https://career.teamtailor.com/jobs/8660969-...)
  Job detail with a full-width cover image, department, city and an "Apply for this job" button.
- `11-teamtailor-apply-form-personal.png` (same job, apply modal)
  Screening questions first, then personal information (first/last name, email, phone with country code)
  and CV upload.
- `12-teamtailor-apply-form-consent.png` (same job, apply modal)
  Additional files, cover letter and three separate consent checkboxes: privacy policy (required),
  consent to be considered for future jobs (optional, can be withdrawn), SMS contact (optional).
- `13-teamtailor-jobs-list-stages.png` (https://www.teamtailor.com/en/applicant-tracking-system/)
  Product screenshot: internal jobs list with status (Pending, Active, Denied, Completed), candidate
  counts per stage, location, recruiter, approvers and paging.

## Greenhouse

- `14-greenhouse-job-board-filters.png` (https://job-boards.greenhouse.io/gitlab)
  Hosted job board: search, department filter, total count ("248 jobs"), jobs grouped by department.
- `15-greenhouse-job-board-paging.png` (same page)
  Paging at the bottom of the job list, "Powered by Greenhouse".
- `16-greenhouse-job-detail.png` (https://job-boards.greenhouse.io/gitlab/jobs/8689243002)
  Job detail with location and an Apply button; the form is on the same page under the description.
- `17-greenhouse-apply-form.png` (same page)
  First/last name, email, country + phone, resume and cover letter (attach or enter manually, allowed
  file types listed), LinkedIn, custom required questions.
- `18-greenhouse-pricing.png` (https://www.greenhouse.com/pricing)
  Tiers Core / Plus / Pro with "Best for" and included features; price only through a demo.

## Lever

- `19-lever-job-board-filters.png` (https://jobs.lever.co/spotify)
  Job board with filters (location type, location, team, work type), jobs grouped by team, Apply
  button on every row, work mode and contract type under each title.
- `20-lever-job-detail.png` (https://jobs.lever.co/spotify/2517cbbf-...)
  Job detail: city, team path, "Permanent / Hybrid", "Apply for this job" button.
- `21-lever-apply-form.png` (.../apply)
  Resume/CV upload first, full name, pronouns, email, phone, current location, current company, links.
- `22-lever-apply-form-consent.png` (.../apply)
  Job-specific question, demographic survey, privacy policy notice and an optional checkbox to be
  contacted about future openings. Footer note about AI use in hiring.

## Recruitee (Tellent)

- `23-recruitee-dashboard.png` (https://recruitee.com/)
  Product screenshot of the home dashboard: recently worked on candidates and jobs (with stage or
  Published status), upcoming interviews, calendar, tabs Overview / Calendar / Evaluations / Tasks /
  Activities.
- `24-recruitee-pipeline-kanban.png` (https://recruitee.com/candidate-pipeline-management)
  Kanban pipeline per job: columns Applied, Phone screen, Interview (collapsed), cards with time in
  stage and a NEW badge, drag and drop, Qualified / Disqualified split. Closest match to the GATS
  Trello-style pipeline.
- `25-recruitee-pipeline-template-settings.png` (same page)
  Pipeline settings: fixed system stages (Sourced, Applied) plus custom stages with name, type and
  time limit, "Template: Advanced" selector, automated actions per stage. Matches GATS system
  stages + custom stages + pipeline template.
- `26-recruitee-pricing-active-job-limits.png` (https://recruitee.com/pricing)
  Start plan includes "5 active job posts", Advance has unlimited job posts. Same limit model as the
  GATS licenses (limit on active/published jobs).
- `27-recruitee-reports-dashboard.png` (https://recruitee.com/reporting)
  Candidate dashboard: KPI tiles (total candidates, disqualified), date and filter controls, charts of
  candidates over time by source.

## Regional job boards

- posao.ba: not captured. The domain now redirects to serda.ba (Sarajevo regional development agency),
  which is not a job board.
- `28-mojposao-job-search-filters.png` (https://mojposao.hr/pretraga-poslova, moj-posao.net redirects here)
  Search by keyword and location, filters (work mode, education, employment type, application
  deadline, driving licence, language), result count, sort by publish date, featured jobs with logos.
- `29-mojposao-job-detail.png` (https://mojposao.hr/posao/e15f3f2c-...)
  Job detail: deadline ("Prijava do"), location, job image, start date, working hours, contract type,
  employer card with website and certificates on the right.
- `30-mojposao-employer-profile.png` (https://mojposao.hr/poslodavac/77ef2ae2-.../kaufland-hrvatska)
  Employer profile: cover photo, "About us" text, more photos, awards and a list of all open jobs of
  the company. Good reference for the GATS public company profile.
- `31-infostud-job-list-salary-range.png` (https://poslovi.infostud.com/oglasi-za-posao)
  Job list (3002 results) with search, city, field of work, sort (newest / expiring soon). Salary shown
  as a range with currency and period ("neto 900 - 1.600 EUR (mesečno)"). The cookie bar has no decline
  option, so it was hidden on screen, not accepted.
- `32-infostud-job-detail.png` (https://poslovi.infostud.com/posao/sales-agent/netpulse-doo/765007)
  Job detail chips: salary range in EUR, number of positions ("10 izvršilaca"), contract type, full
  time, shifts, "notification of application review". Tabs: job text / about employer.
- `33-infostud-hrlab-pricing.png` (https://www.hrlab.rs/cene-oglasa-za-posao)
  Infostud employer side (HR Lab): job ad packages Mini / Start / Standard / Progresiv / Premium,
  prices in RSD, ad duration toggle 15 / 30 days, features per package.

## Ideas GATS could adopt

The related GATS issue is given in brackets.

1. Kanban pipeline like Recruitee: show time in stage on each card, a NEW badge for unseen applicants,
   collapsible columns, and a Qualified / Rejected split. (#24, #29)
2. Pipeline template in Settings: system stages locked, custom stages editable (name, order, optional
   time limit), applied to new jobs. (#17, #38)
3. Job list for the company with stage counts per job and a status badge (Draft / Published / Closed),
   as in Teamtailor. (#15, #18)
4. Separate consent checkboxes on the apply form: required GDPR/privacy consent and an optional
   "keep my data for future jobs" consent (useful for open applications). (#21, #37)
5. Show salary as "min - max currency / period" on cards and job detail (Infostud), and number of
   positions as a chip. (#19, #20, #28)
6. Public company profile: cover image, mission/about text, gallery, list of open jobs (MojPosao,
   Teamtailor, Workable). (#36)
7. Public job board: search + filters (city, work mode, employment type, seniority), result count,
   sort by newest or deadline, paging. (#19)
8. Licence page: plans as cards with the active job limit as the main difference (Recruitee "5 active
   job posts" vs unlimited), monthly price and duration, like Infostud's 15/30 day toggle. (#8, #9)
9. Dashboard: KPI tiles (open jobs, new applicants, hired, rejected) plus a chart of applications over
   time and upcoming items. (#33)
10. Candidate profile with tabs (profile, notes, ratings, files, timeline), as in Workable. (#26, #27)

## Could not capture

- posao.ba (redirects to an unrelated site).
- Teamtailor product pipeline and candidate profile: the ATS feature page shows mostly animations and
  videos; only the jobs list image was usable.
- Email template and settings screens: none of the products show them on public pages without logging
  in or a demo (help center articles would be the next place to look).
- Greenhouse and Lever internal screens (pipeline, scorecards): not on public marketing pages that
  loaded cleanly.
- Exact prices for Workable are in USD only; Teamtailor, Greenhouse and Recruitee give prices only
  through a quote or demo.
